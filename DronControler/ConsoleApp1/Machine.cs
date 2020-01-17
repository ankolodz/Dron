using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Machine
    {
        private UART myUART;
        public Engine engine;
        public Gyroscope gyroscope;
        public Throtle throtle;


        public Machine (UART uart)
        {
            this.myUART = uart;
            engine = new Engine(uart);
            gyroscope = new Gyroscope();
            throtle = new Throtle(uart);
        }
        public void messageHandler  (byte[] message)
        {
            Console.WriteLine(message[0]+" "+message[1]+" " +message[2] + " "+message[3] + " " + message[4] + " " + message[5] + " ");
            int suma = 0;
            for (int i = 0; i < UART.messageSize()-1; i++)
                suma += message[i];
            if  (suma % 256 != message[5])
            {
                Console.WriteLine(suma%256 + " "+message[5]);
                Exception incorectMessageControlSum = new Exception("Błąd sumy kontrolnej");
                throw incorectMessageControlSum;
            }

            switch (message[0])
            {
                case 1:
                    engine.readMessage(message);
                    break;
                case 2:
                    gyroscope.readMessage(message);
                    break;
                default:
                    Exception incorectMessageType = new Exception("Błąd typu ramki");
                    throw incorectMessageType;
            }
        }
        public void STOP()
        {
            engine.STOP();
        }

        
    }
}
