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
        private static byte N = 5;

        public void down()
        {
            enginePower = (byte) Math.Max(0, enginePower - N);
            
        }

        public void up()
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
        private static byte N = 3;

        public void down()
        {
            throtle = (byte)Math.Max(0, throtle - N);

        }

        public void up()
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

        public void down()
        {
            value = (byte)Math.Max(0, value - 1);

        }

        public void up()
        {
            value = (byte)Math.Min(MAX, value + 1);
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
