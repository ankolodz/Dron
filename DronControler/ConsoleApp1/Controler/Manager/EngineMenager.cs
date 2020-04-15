using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DronApp
{
    public class EngineManager : Component
    {
        private byte typ=1;
        private Engine[] engines;
        Proxy proxy;
        private bool manual = false;



        public EngineManager(Proxy proxy) {
            this.proxy = proxy;
            this.engines = new Engine[4];
            for (int i = 0; i < 4; i++)
                engines[i] = new Engine();
            Console.WriteLine(engines[0].getState());
        }

        public byte[] getEngineState()
        {
            byte[] frame = new byte[4];
            frame[0] = engines[0].getState();
            frame[1] = engines[1].getState();
            frame[2] = engines[2].getState();
            frame[3] = engines[3].getState();
            return frame;
        }
 

        public override byte getType() => this.typ;
  
    
        public void upEnginePower(int EngineNb)
        {
            switch (EngineNb){
                case 1:
                    engines[0].up();
                    break;
                case 2:
                    engines[1].up();
                    break;
                case 3:
                    engines[2].up();
                    break;
                case 4:
                    engines[3].up();
                    break;
                case 5:
                    engines[0].up();
                    engines[1].up();
                    engines[2].up();
                    engines[3].up();
                    break;            
            }
            base.isChange();
        }

        public void downEnginePower(int EngineNb)
        {
                switch (EngineNb)
                {
                    case 1:
                        engines[0].down();
                        break;
                    case 2:
                        engines[1].down();
                        break;
                    case 3:
                        engines[2].down();
                        break;
                    case 4:
                        engines[3].down();
                        break;
                    case 5:
                        engines[0].down();
                        engines[1].down();
                        engines[2].down();
                        engines[3].down();
                        break;
                }
            base.isChange();
        }

        public void STOP()
        {           
            base.SendComend(proxy, 0, 0, 0, 0);

        }

        public override void readMessage(byte[] message)
        {
            if (message[0] == typ && !manual)
            {
                engines[0].set(message[1]);
                engines[1].set(message[2]);
                engines[2].set(message[3]);
                engines[3].set(message[4]);
            }
        }

        public void manualON() { manual = true; }

        public void manualOFF() { manual = false; }

        public bool getManualState() { return manual; }
    };
}
