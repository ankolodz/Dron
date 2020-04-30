using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    class Engine : Controler
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

    public class Throtle : Controler
    {
        private byte throtle = 0;

        public void down(int N)
        {
            throtle = (byte)Math.Max(0, throtle - N);

        }

        public void up(int N)
        {
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

    class SingleRudder : Controler
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
