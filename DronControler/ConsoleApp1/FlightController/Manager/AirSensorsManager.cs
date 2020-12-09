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
        private bool test;
        public override byte getType()
        {
            throw new NotImplementedException();
        }

        public override void readMessage(byte[] message)
        {
            throw new NotImplementedException();
        }

        public float getPM10() {
            throw new NotImplementedException();
        }

        public float getTemp() { throw new NotImplementedException(); }

        public float getGPSlongitude() { throw new NotImplementedException(); }
        public float getGPSlatitude() { throw new NotImplementedException(); }

        private void setPM10(byte[] val) { }

        private void setTemp(byte[] val) { }

        private void getGPSlongitude(byte[] val) { }
        private void getGPSlatitude(byte[] val) { }
    }
}
