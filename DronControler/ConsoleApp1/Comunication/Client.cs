using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp.Comunication
{
    public interface Client
    {
        void init();
        void sendMessage(byte[] message, int size);
    }
}
