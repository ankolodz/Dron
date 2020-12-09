using System;
using System.Windows.Forms;

namespace DronApp.ControlManager
{
    class KeybordController
    {
        public event System.Windows.Forms.KeyEventHandler KeyDown;
        private Mediator mediator;

        public KeybordController(Mediator mediator)
        {
            this.mediator = mediator;
            this.KeyDown += new KeyEventHandler(this.lisiner);
        }

        public bool init()
        {

            return true;
        }

        public void startLisiner()
        {

        }

        public void lisiner(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    mediator.getMachine().flyController.upThrotle();
                    break;
                case Keys.Z:
                    mediator.getMachine().flyController.downThrotle();
                    break;
                case Keys.D0:
                    mediator.getMachine().start(false);
                    break;
                case Keys.Q:
                    mediator.getMachine().start(true);
                    break;
                default:
                    mediator.getMachine().STOP();
                    break;

            }
            Console.WriteLine("OK");
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
    }
}
