using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp.ControlManager
{
    class KeybordController : iController
    {
        private Machine machine;

        public KeybordController(Machine machine)
        {
            this.machine = machine;
        }

        public bool init()
        {
            throw new NotImplementedException();
        }

        public void startLisiner()
        {
            throw new NotImplementedException();
        }
    }
}
