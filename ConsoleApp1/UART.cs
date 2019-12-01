using System;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace ConsoleApp1
{

    public class UART
    {
        int bid = 0;
        SerialPort portCOM = new SerialPort();

        public void initCOM()
        {

            portCOM.ReadTimeout = 500;
            portCOM.WriteTimeout = 500;
            portCOM.BaudRate = 9600;
            portCOM.DataBits = 8;
            portCOM.StopBits = StopBits.One;

            string portName = File.ReadAllText(@"./COMname.txt");
            var ports = SerialPort.GetPortNames();
            for (int i1 = 0; i1 < ports.Length; i1++)
            {
                Console.WriteLine(ports[i1]);
            }

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
                    initCOM();
                }
            }
        }

        public void end()
        {
            portCOM.Close();
        }

        private void DataRecivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine(portCOM.ReadExisting());
        }

        public void sendMessage(byte[] byteArr, int length) => portCOM.Write(byteArr, 0,length);
    }
}
