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

        private Thread t;
        private int accurancyThrotle = 10, accurancyRudder = 80;
        private int oX, oY, sX, sY, lastDirect;


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
            sX = 0; sY = 0;
            lastDirect = 0;

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
            t = new Thread(new ThreadStart(startLisiner));
            t.Start();
            return true;

        }
        public void stop()
        {
            t.Abort();
        }
 
        public void startLisiner()
        {
            while (true)
            {
                joystick.Poll();
                JoystickState state = joystick.GetCurrentState();

                rightStick(state);
                leftStick(state);
                testButtonsPress();           

                Thread.Sleep(200);
            }
        }


        private void rightStick(JoystickState state)
        {
            //Maping rudder
            if (oX != convert(state.Z, accurancyRudder))
            {
                oX = convert(state.Z, accurancyRudder);
                machine.flyController.setHorizontal(oX);
            }
            if (oY != convert(state.RotationZ, accurancyRudder))
            {
                oY = convert(state.RotationZ, accurancyRudder);
                machine.flyController.setVertical(oY);
            }
        }

        private void leftStick(JoystickState state)
        {
            //Maping throtle
            if (convert(state.Y, accurancyThrotle) != accurancyThrotle / 2)
            {
                sY = convert(state.Y, accurancyThrotle);
                if (sY < accurancyThrotle / 2)
                    machine.flyController.upThrotle(accurancyThrotle / 2 - sY);
                else
                    machine.flyController.downThrotle(sY - accurancyThrotle / 2);
            }
        }


        private void testButtonsPress()
        {
            IList<JoystickState> myobject = joystick.GetBufferedData();
            foreach (var i in myobject)
            {

                //Maping accurate throttle
                if (i.GetPointOfViewControllers()[0] == -1)
                {
                    switch (lastDirect)
                    {
                        //single throtle
                        case 0:
                            machine.flyController.upThrotle(1);
                            break;
                        case 18000:
                            machine.flyController.downThrotle(1);
                            break;

                    }
                }
                lastDirect = i.GetPointOfViewControllers()[0];

                if (i.IsPressed(1))
                    machine.flyController.STOP();

            }
        }

        private int convert(int val, int accurancy)
        {
            int one = 65535 / accurancy;
            return val / one;
        }


    }



}
