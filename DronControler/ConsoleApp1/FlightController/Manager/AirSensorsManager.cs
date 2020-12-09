using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DronApp;

namespace DronApp
{
    public class AirSensorsManager : Component
    {
        private byte type = 129;
        private int PM25 = 0;
        private int PM10 = 0;
        private float temp = 0;
        private Mediator mediator;
        public override byte getType()
        {
            return type;
        }

        public AirSensorsManager(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public override void readMessage(byte[] message)
        {
           PM10 = message[2];
           PM25 = message[3];
           setTemp(message[1]);
           this.mediator.getDebug().addLog(message);
        
        }

        public float getPM10() {
            return PM10;
        }

        public float getPM25()
        {
            return PM25;
        }

        public float getTemp() { return temp; }

        public float getGPSlongitude() { throw new NotImplementedException(); }
        public float getGPSlatitude() { throw new NotImplementedException(); }

        private void setTemp(byte val) {
            temp = val / 4 - 10;
                }

        private void getGPSlongitude(byte[] val) { }
        private void getGPSlatitude(byte[] val) { }

        internal void refresh()
        {
            base.SendComend(mediator, 0, 0, 0, 0);
        }
    }
}
