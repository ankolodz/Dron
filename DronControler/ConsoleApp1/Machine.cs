using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Machine
    {
        private Client client;
        public Engine engine;
        public Gyroscope gyroscope;
        public Throtle throtle;


        public Machine (Client client)
        {
            this.client = client;
            engine = new Engine(client);
            gyroscope = new Gyroscope();
            throtle = new Throtle(client);
        }
        public void messageHandler  (byte[] message)
        {
            Console.WriteLine(message[0]+" "+message[1]+" " +message[2] + " "+message[3] + " " + message[4] + " " + message[5] + " ");

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
