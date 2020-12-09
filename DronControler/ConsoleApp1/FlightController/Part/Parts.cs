using System;

namespace DronApp
{
    class Engine : Part
    {
        private byte enginePower = 0;

        public void down(int N = 5)
        {
            enginePower = (byte) Math.Max(0, enginePower - N);            
        }

        public void up(int N = -5)
        {
            enginePower = (byte)Math.Min(255, enginePower + N);
        }

        public byte getState()
        {
            return enginePower;
        }

        public void set(byte value)
        {
            this.enginePower =  value;
        }

    }

    //******************************************************************

    public class Throtle : Part
    {
        private byte throtle = 0;

        public void down(int N)
        {
            if (throtle <= 30)
                return;
            throtle = (byte)Math.Max(30, throtle - N);

        }

        public void up(int N)
        {
            if (throtle == 0)
                return;
            throtle = (byte)Math.Min(255, throtle + N);
        }


        public byte getState()
        {
            return throtle;
        }

        public void set(byte value)
        {
            this.throtle = value;
        }
    }

    //******************************************************************

    class SingleRudder : Part
    {
        private static byte MAX = 80;
        private byte value = 40;  // MAX/2      


        public void down(int val=1)
        {
            value = (byte)Math.Max(0, value - val);

        }

        public void up(int val=-1)
        {
            value = (byte)Math.Min(MAX, value + val);
        }

        public byte getState()
        {
            return value;
        }

        public void set(byte value)
        {
            this.value = value;
        }

    }
}
