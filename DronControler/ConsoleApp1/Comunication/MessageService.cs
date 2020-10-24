using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DronApp
{
    public class MessageService: ServiceState
    {
        private MessageScheduler schreduler;
        private SerialPort portCOM = new SerialPort();
        private Proxy proxy;
        private State state { get; set; }//TODO i=ogarnij to geniuszu
        private Thread senderThread;

        private String portName;
        private int bid = 0;
        private object usingCOM = new object();
        private bool activeFastMode = false;

        public MessageService(Proxy proxy)
        {
            this.schreduler = new MessageScheduler();
            proxy.SetMessageService(schreduler, this);
            this.proxy = proxy;
            this.portCOM = new SerialPort();
            getPortName();
        }

        private void getPortName()
        {
            var form = new SelectDialog(SerialPort.GetPortNames());
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.portName = form.selectedPort;
                this.run();
            }
        }

        private void run()
        {
            Console.WriteLine("OK");
            portCOM.ReadTimeout = 500;
            portCOM.WriteTimeout = 500;
            portCOM.BaudRate = 9600;
            portCOM.DataBits = 8;
            portCOM.ReceivedBytesThreshold = Parameters.messageSize;
            portCOM.StopBits = StopBits.One;
            portCOM.PortName = portName;
            portCOM.DataReceived += new SerialDataReceivedEventHandler(MessageRecivedHandler);

            try
            {
                portCOM.Open();
                bid = 0;
            }
            catch (Exception e)
            {
                this.state = State.error;
                proxy.getDebug().addLog(ErrorDebugMessage.portNotReplyError);
                if (bid < 10)
                {
                    bid++;
                    Thread.Sleep(Parameters.portRefreshTimeOut);
                    run();
                }
            }
            this.state = State.warning;
            this.setOFF();
            this.senderThread = new Thread(this.sendHandler);
            this.senderThread.Start();
        }

        private void MessageRecivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            lock (usingCOM)
            {
                if (this.portCOM.BytesToRead < 8)
                    return;
                byte[] arr = readMsg();

                if (controlSum(arr))
                    proxy.getMachine().messageHandler(arr);
                proxy.getDebug().addLog(arr);
                Monitor.Pulse(usingCOM);
            }                 
        }

        private bool controlSum(byte[] message)
        {
            int suma = 0;
            for (int i = 0; i < message.Length - 1; i++)
                suma += message[i];
            return suma % 256 != message[message.Length - 1] ? false : true;
        }

        private void sendHandler()
        {
            try
            {           
                lock (usingCOM)
                {
                    while (true)
                    {
                        byte[] dataToSend = schreduler.getNextMessage();
                        proxy.getDebug().addLog(dataToSend);
                        if (!activeFastMode)
                        {
                            Thread.Sleep(Parameters.sleepSlowMessageTime);
                           // Console.WriteLine("W!");
                        }
                            
                        portCOM.Write(dataToSend, 0, dataToSend.Length);
                        Monitor.Wait(usingCOM, Parameters.lostMessageTimeout);
                    }
                }
            }
            catch (Exception)
            {
                proxy.getDebug().addLog(ErrorDebugMessage.lostConnection);
                this.close();
                this.run();
            }
        }


        private byte[] readMsg()
        {
            byte[] arr = new byte[Parameters.messageSize];
            while (portCOM.BytesToRead < Parameters.messageSize) Thread.Sleep(1);
            portCOM.Read(arr, 0, Parameters.messageSize);
            return arr;
        }

        public void close()
        {
            this.senderThread.Abort();
            this.portCOM.Close();
        }

        public void setON()
        {
            proxy.getDebug().addLog("========================NOWY START========================");
            this.activeFastMode = true;
            this.state = State.active;
        }

        public void setOFF()
        {
            this.activeFastMode = false;
            this.state = State.warning;
            proxy.getDebug().saveToFile();
        }

        public State getState()
        {
            return this.state;
        }
    }
}
