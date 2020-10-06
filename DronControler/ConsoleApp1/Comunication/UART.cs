using System;
using System.IO.Ports;
using System.Threading;

namespace DronApp.Comunication
{
    class UART : Client
    {
        private int bid = 0;
        private SerialPort portCOM = new SerialPort();
        private Proxy proxy;
        private State state;
        private String portName;
        private byte[] dataToSend = { 1, 0, 0, 0, 0, 1 };

        public UART(Proxy proxy)
        {
            this.proxy = proxy;
        }

        public void init()
        {
            var ports = SerialPort.GetPortNames();
            for (int i1 = 0; i1 < ports.Length; i1++)
                Console.WriteLine(ports[i1]);

            portName = Console.ReadLine();
            run();
        }

        private void run()
        {
            portCOM.ReadTimeout = 500;
            portCOM.WriteTimeout = 500;
            portCOM.BaudRate = 9600;
            portCOM.DataBits = 8;
            portCOM.StopBits = StopBits.One;
            portCOM.PortName = portName;

            portCOM.DataReceived += new SerialDataReceivedEventHandler(DataRecivedHandler);

            try
            {
                portCOM.Open();
                bid = 0;
            }
            catch (Exception e)
            {
                DebugMode.addLog("Error connection, port not reply");
                if (bid < 10)
                {
                    bid++;
                    Thread.Sleep(500);
                    Console.WriteLine("Błąd portu");
                    init();
                }
            }
            this.state = State.warning;
        }

        public void end()
        {
            portCOM.Close();
        }
        private bool controlSum(byte[] message)
        {
            // int suma = 0;
            // for (int i = 0; i < UART.messageSize() - 1; i++)
            //    suma += message[i];
            //return suma % 256 != message[5] ? false : true;
            return true;
        }
        private void DataRecivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] arr = new byte[messageSize()];
            while (portCOM.BytesToRead < messageSize()) Thread.Sleep(1);

            portCOM.Read(arr, 0, messageSize());
            try
            {
                if (controlSum(arr))
                     proxy.getMachine().messageHandler(arr);
                DebugMode.addLog(arr);
                sendMsg();

            }
            catch
            {
                try
                {
                    Console.WriteLine("Błąd ramki");
                    portCOM.ReadExisting();
                    sendMsg();
                }
                catch
                {
                    Console.WriteLine("Nieudane czyszczenie bufora");
                    DebugMode.addLog("Error UART, cleaning buffer failed");
                }
            }

        }
        public static int messageSize()
        {
            return 8;
        }
        private void sendMsg()
        {
            try
            {
                portCOM.Write(dataToSend, 0, dataToSend.Length);
            }
            catch (Exception e)
            {
                this.state = State.error;
                try
                {
                    end();
                }
                catch (Exception ex)
                {
                }
                run();
            }
        }

        public void nextMessage(byte[] byteArr, int length)
        {
            this.dataToSend = byteArr;
        }

        public State getState()
        {
            return this.state;
        }

        public void setState(State state)
        {
            this.state = state;
            sendMsg();
            DebugMode.addLog("========================NOWY START========================");
        }
    }
}

