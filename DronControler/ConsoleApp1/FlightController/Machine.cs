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
            gyroscope = new Gyroscope();
            flyController = new FlyManager(proxy);
        }
        public void sendToReal()
        {
            flyController.sendFlyController();
        }
        public void messageHandler  (byte[] message)
        {
            Console.WriteLine(message[0]+" "+message[1]+" " +message[2] + " "+message[3] + " " + message[4] + " " + message[5] + " "+message[6]+" "+message[7]);

            engine.readMessage(message);
            gyroscope.readMessage(message);
        }
        public void STOP()
        {
            engine.STOP();
            flyController.STOP();
            readyForStart = false;
            proxy.setOFF();
        }
        public void start(bool power)
        {
            if (readyForStart == false && power == false)
            {
                readyForStart = true;
                proxy.setON();
                return;
            }
            if (power == true && readyForStart == true)
            {                
                flyController.setThrotle(45);
            }
        
        }

        
    }
}
