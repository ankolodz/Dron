using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public class Machine
    {
        private Mediator mediator;
        public readonly EngineManager engine;
        public readonly Gyroscope gyroscope;
        public readonly FlyManager flyController;
        public readonly AirSensorsManager airSensors;
        private Boolean readyForStart = false;


        public Machine (Mediator mediator)
        {
            this.mediator = mediator;
            engine = new EngineManager(mediator);
            gyroscope = new Gyroscope();
            flyController = new FlyManager(mediator);
            airSensors = new AirSensorsManager();
        }
        public void sendToReal()
        {
            flyController.sendFlyController();
        }
        public void messageHandler  (byte[] message)
        {
            engine.readMessage(message);
            gyroscope.readMessage(message);
            airSensors.readMessage(message);
        }
        public void STOP()
        {
            engine.STOP();
            flyController.STOP();
            readyForStart = false;
            mediator.setOFF();
        }
        public void start(bool power)
        {
            if (readyForStart == false && power == false)
            {
                readyForStart = true;
                mediator.setON();
                return;
            }
            if (power == true && readyForStart == true)
            {                
                flyController.setThrotle(45);
            }        
        }

        
    }
}
