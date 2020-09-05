using System;
using System.Windows.Forms;

namespace DronApp.ControlManager
{
    class KeybordController : Control, iController 
    {
        public event System.Windows.Forms.KeyEventHandler KeyDown;
        private Machine machine;

        public KeybordController(Machine machine)
        {
            this.machine = machine;
            this.KeyDown += new KeyEventHandler(this.lisiner);
        }

        public bool init()
        {
            
            return true;
        }

        public void startLisiner()
        {

        }

        public void lisiner (object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    machine.flyController.upThrotle();
                    break;
                case Keys.Z:
                    machine.flyController.downThrotle();
                    break;
                case Keys.D0:
                    machine.start(false);
                    break;
                case Keys.Q:
                    machine.start(true);
                    break;
                default:
                    machine.STOP();
                    break;

            }
            Console.WriteLine("OK");
        }
    }
}
