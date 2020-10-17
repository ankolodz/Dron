using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public class Proxy
    {
        private SendMessageService messageService;
        private Machine machine;

        public bool active = true;
        public SendMessageService GetMessageService() => this.messageService;
        public Machine getMachine() => machine;

        public void SetMessageService(SendMessageService messageService){
            this.messageService = messageService;
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
            // udp.setState(State.active);           
            
        }
        public void setOFF()
        {
            SLEEP = off;
            // udp.setState(State.warning);
        }
        public int getSleepTime()
        {
            return SLEEP;
        }

    }

}
