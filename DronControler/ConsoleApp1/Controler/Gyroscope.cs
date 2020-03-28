﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gyroscope : Unit
    {
        private byte type = 2;
        private int x = 125;
        private int y = 125;

        public override byte getType()
        {
            return type;
        }

        public override void readMessage(byte[] message)
        {
            x = message[1];
            y = message[2];

        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    };
}