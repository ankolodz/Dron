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
            x = message[2];
            y = message[3];
            z = message[4];
        }

        public int getX()
        {
            return x - Parameters.zeroGyroMaping;
        }

        public int getY()
        {
            return y - Parameters.zeroGyroMaping;
        }

        public int getZ()
        {
            return z - Parameters.zeroGyroMaping;
        }
    };
}
