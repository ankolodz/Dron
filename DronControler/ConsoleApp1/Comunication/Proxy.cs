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
    }
}
