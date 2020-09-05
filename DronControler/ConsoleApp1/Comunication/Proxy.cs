using DronApp.Comunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public class Proxy
    {
        private Client udp = null;
        private Machine machine = null;

        public Client getUDP() => udp;
        public Machine getMachine() => machine;

        public void setUDP(Client client){
            this.udp = client;
        }


        public void setMachine(Machine machine){
            this.machine = machine;
        }

        private int SLEEP = 200;
        private readonly int on = 200;
        private readonly int off = 1000;

        public void setON()
        {
            SLEEP = on;
        }
        public void setOFF()
        {
            SLEEP = off;
        }
        public int getSleepTime()
        {
            return SLEEP;
        }

    }

}
