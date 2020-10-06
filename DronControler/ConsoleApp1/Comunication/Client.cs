using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public interface Client
    {
        State getState();
        void setState(State state);
        void init();
        void nextMessage(byte[] byteArr, int length);
    }
}
