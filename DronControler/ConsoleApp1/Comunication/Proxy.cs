using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public class Proxy
    {
        Client udp = null;
        Machine machine = null;

        public Client getUDP() => udp;
        public Machine getMachine => machine;

        public void setUDP(Client client){
            this.udp = client;
        }

        public void registerMachine(Machine machine){
            this.machine = machine;
        }
    }
}
