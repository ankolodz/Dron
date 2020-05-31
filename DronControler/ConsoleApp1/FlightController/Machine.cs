using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public class Machine
    {
        private Proxy proxy;
        public readonly EngineManager engine;
        public readonly Gyroscope gyroscope;
        public readonly FlyManager flyController;
        private Boolean readyForStart = false;


        public Machine (Proxy proxy){
            this.proxy = proxy;
            engine = new EngineManager(proxy);
            //gyroscope = new Gyroscope();
            flyController = new FlyManager(proxy);
        }
        public void sendToReal()
        {
            flyController.sendFlyController();
        }
        public void messageHandler  (byte[] message)
        {
            Console.WriteLine(message[0]+" "+message[1]+" " +message[2] + " "+message[3] + " " + message[4] + " " + message[5] + " ");

            switch (message[0])
            {
                case 1:
                    engine.readMessage(message);
                    break;
               // case 2:
                  // // gyroscope.readMessage(message);
                   // break;
               // default:
                   // Exception incorectMessageType = new Exception("Błąd typu ramki");
                   // throw incorectMessageType;
            }
        }
        public void STOP()
        {
            engine.STOP();
            flyController.STOP();
            readyForStart = false;
        }
        public void start(bool power)
        {
            if (readyForStart == false && power == false)
            {
                readyForStart = true;
                return;
            }
            if (power == true && readyForStart == true)
            {
                flyController.setThrotle(45);
            }
        
        }

        
    }
}
