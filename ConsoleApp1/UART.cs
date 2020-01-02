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
        Machine machine;

        public void setMachine(Machine machine)
        {
            this.machine = machine;
        }

        public void initCOM()
        {

            portCOM.ReadTimeout = 500;
            portCOM.WriteTimeout = 500;
            portCOM.BaudRate = 19200;
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
            // Console.WriteLine(portCOM.ReadExisting());
            byte[] arr = new byte[messageSize()];
            while(portCOM.BytesToRead < messageSize())
            {
                Thread.Sleep(1);
            }

            portCOM.Read(arr,0, messageSize());
            try
            {
               machine.messageHandler(arr);
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
        public static int messageSize(){
            return 6;}

        public void sendMessage(byte[] byteArr, int length) => portCOM.Write(byteArr, 0,length);
    }
}
