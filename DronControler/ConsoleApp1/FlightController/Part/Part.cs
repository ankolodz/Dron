using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{

    interface Part
    {
        void up(int val);
        void down(int val);
        byte getState();
        void set(byte value);
             
    }

    interface Sensor
    {
        float getVal();
        void setVal(byte[] val);
    }
}
