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
        private ServiceState serviceState;
        private Machine machine;
        private DebugModule debug;
            
        public bool active = true;
        public SendMessageService GetMessageService() => this.messageService;
        public Machine getMachine() => machine;

        public DebugModule getDebug() => debug;

        public void SetMessageService(SendMessageService messageService, ServiceState serviceState){
            this.messageService = messageService;
            this.serviceState = serviceState;
        }

        public void setDebugModule(DebugModule debugModule)
        {
            this.debug = debugModule;
        }


        public void setMachine(Machine machine){
            this.machine = machine;
        }

        public void setON()
        {
            this.serviceState.setON();  
        }
        public void setOFF()
        {
            this.serviceState.setOFF();
        }
        public int getSleepTime()
        {
            return this.serviceState.getState() == State.error ? Parameters.refreshViewSleep : Parameters.refreshView;
        }

        public State getState()
        {
            return this.serviceState.getState();
        }
    }
}
