using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DronApp.Comunication
{
    class UART : Client
    {
        private int bid = 0;
        private SerialPort portCOM = new SerialPort();
        private Proxy proxy;

        public UART(Proxy proxy)
        {
            this.proxy = proxy;
        }

        public void init()
        {
            var ports = SerialPort.GetPortNames();
            for (int i1 = 0; i1 < ports.Length; i1++)            
                Console.WriteLine(ports[i1]);
            

            portCOM.ReadTimeout = 500;
            portCOM.WriteTimeout = 500;
            portCOM.BaudRate = 9600;
            portCOM.DataBits = 8;
            portCOM.StopBits = StopBits.One;
            portCOM.PortName = Console.ReadLine();

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
        }

        public void end()
        {
            portCOM.Close();
        }
        private bool controlSum(byte[] message)
        {
            int suma = 0;
            for (int i = 0; i < UART.messageSize() - 1; i++)
                suma += message[i];
            return suma % 256 != message[5] ? false : true;
        }
        private void DataRecivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // Console.WriteLine(portCOM.ReadExisting());
            byte[] arr = new byte[messageSize()];
            while (portCOM.BytesToRead < messageSize()) Thread.Sleep(1);

            portCOM.Read(arr, 0, messageSize());
            try
            {
                if (controlSum(arr))
                    proxy.getMachine().messageHandler(arr);
            }
            catch
            {
                try
                {
                    Console.WriteLine("Błąd ramki");
                    portCOM.ReadExisting();
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
            return 6;
        }

        public void sendMessage(byte[] byteArr, int length) => portCOM.Write(byteArr, 0, length);
    }
}

