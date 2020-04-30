using SlimDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DronApp.ControlManager
{
    public class  GamePad : iController
    {
        private Joystick joystick;
        private Machine machine;

        private int accurancyThrotle = 40, accurancyRudder = 80;
        private int oX, oY,sX, sY;


        public GamePad(Machine machine)
        {
            this.machine = machine;
        }

        public GamePad(Machine machine, int accurancyThrotle, int accurancyRudder) : this(machine)
        {
            this.accurancyThrotle = accurancyThrotle;
            this.accurancyRudder = accurancyRudder;
        }

        public bool init()
        {
            oX = accurancyThrotle / 2; oY = accurancyThrotle / 2;
            sX = accurancyRudder / 2; sY = accurancyRudder / 2;

            // Initialize DirectInput
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad,
                        DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick,
                        DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick");
                return false;
            }

            // Instantiate the joystick
            this.joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Connect with Joystick");

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

            return true;

        }

        public void startLisiner()
        {
            //    poll events from joystick
            while (true)
            {
                joystick.Poll();
                var state = joystick.GetCurrentState();
                var myobject = joystick.GetObjects();


                //Maping throtle
                if (sX != state.Z % accurancyThrotle)
                {
                    sX = state.Z % accurancyThrotle;
                    machine.flyController.upThrotle(sX);
                }
                if (sY != state.RotationZ % accurancyThrotle)
                {
                    sY = state.RotationZ % accurancyThrotle;
                    machine.flyController.downThrotle(sY);
                }
                //Maping rudder
                if (oX != state.X % accurancyRudder)
                {
                    oX = state.X % accurancyRudder;
                    machine.flyController.setHorizontal(oX);
                }
                if (oY != state.Y % accurancyRudder)
                {
                    oY = state.Y % accurancyRudder;
                    machine.flyController.setVertical(oY);
                }
                Console.WriteLine("OK");
                Thread.Sleep(100);
            }
        }


    }



}
