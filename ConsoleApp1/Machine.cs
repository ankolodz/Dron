using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Machine
    {
        private UART myUART;
        private Engine engine;
        private Form1 GUI;

        public Machine (UART uart,Form1 GUI)
        {
            this.myUART = uart;
            engine = new Engine(uart,GUI);
            this.GUI = GUI;
        }
        public void STOP()
        {
            engine.STOP();
        }

        
    }
}
