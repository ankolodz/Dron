using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp.ControlManager
{
    public interface iController
    {
        bool init();
        void startLisiner();

        void stop();
    }
}
