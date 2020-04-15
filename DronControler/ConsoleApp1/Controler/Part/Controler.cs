using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{

    interface Controler
    {
        void up();
        void down();
        byte getState();
        void set(byte value);
             
    }
}
