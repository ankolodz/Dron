using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public class Gyroscope : Component
    {
        private byte type = 10;
        private int x = 127;
        private int y = 127;
        private int z = 127;

        public override byte getType()
        {
            return type;
        }

        public override void readMessage(byte[] message)
        {
            y = message[5];
            x = message[6];
            z = message[7];
        }

        public float getX()
        {
            return (x - Parameters.zeroGyroMaping)/2;
        }

        public float getY()
        {
            return (y - Parameters.zeroGyroMaping)/2;
        }

        public int getZ()
        {
            return z - Parameters.zeroGyroMaping/2;
        }
    };
}
