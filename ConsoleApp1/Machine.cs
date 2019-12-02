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
        private Gyroscope gyroscope;
        public Throtle throtle;
        private Form1 GUI;

        public void refresch()
        {
            GUI.SetEnginePower(engine.getEngineState());
            GUI.SetGyroscope(gyroscope.getX(), gyroscope.getY());
            GUI.SetThrotle(throtle.getThrotle());
        }

        public Machine (UART uart,Form1 GUI)
        {
            this.myUART = uart;
            engine = new Engine(uart);
            gyroscope = new Gyroscope();
            throtle = new Throtle(uart);
            this.GUI = GUI;
        }
        public void messageHandler  (byte[] message)
        {
            switch (message[0])
            {
                case 1:
                    engine.readMessage(message);
                    break;
                case 2:
                    gyroscope.readMessage(message);
                    break;
            }
        }
        public void STOP()
        {
            engine.STOP();
        }

        
    }
}
