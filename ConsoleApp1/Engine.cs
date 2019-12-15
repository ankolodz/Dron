using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Engine : Unit
    {
        private byte typ=1;
        private byte moc_P_L=0;
        private byte moc_P_P = 0;
        private byte moc_T_L = 0;
        private byte moc_T_P = 0;
        private static byte N = 1;
        UART myUart;
        private bool manual;
       // Form1 GUI;

        public Engine(UART uart) {
            this.myUart = uart;
           // this.GUI = GUI;
        }
        public byte[] getEngineState()
        {
            byte[] engines = new byte[4];
            engines[0] = moc_P_L;
            engines[1] = moc_P_P;
            engines[2] = moc_T_L;
            engines[3] = moc_T_P;
            return engines;
        }
 

        public override byte getType() => this.typ;
  
    
        public void upEnginePower(int EngineNb)
        {switch (EngineNb)
            {
                case 1:
                    if (moc_P_L+N<255)
                        moc_P_L += N;
                    break;
                case 2:
                    if (moc_P_P + N < 255)
                        moc_P_P += N;
                    break;
                case 3:
                    if (moc_T_L + N < 255)
                        moc_T_L += N;
                    break;
                case 4:
                    if (moc_T_P + N < 255)
                        moc_T_P += N;
                    break;
                case 5:                
                    if (moc_P_L + N < 255)
                        moc_P_L += N;

                    if (moc_P_P + N < 255)
                        moc_P_P += N;

                    if (moc_T_L + N < 255)
                        moc_T_L += N;

                    if (moc_T_P + N < 255)
                        moc_T_P += N;
                    break;


            }
           
            base.SendComend(myUart,moc_P_L,moc_P_P,moc_T_L,moc_T_P);
        }
        public void downEnginePower(int EngineNb)
        {
            switch (EngineNb)
            {
                case 1:
                    if (moc_P_L - N > 0)
                        moc_P_L -= N;
                    else
                        moc_P_L = 0;
                    break;
                case 2:
                    if (moc_P_P - N > 0)
                        moc_P_P -= N;
                    else
                        moc_P_P = 0;
                    break;
                case 3:
                    if (moc_T_L - N > 0)
                        moc_T_L -= N;
                    else
                        moc_T_L = 0;
                    break;
                case 4:
                    if (moc_T_P - N > 0)
                        moc_T_P -= N;
                    else
                        moc_T_P = 0;
                    break;
                case 5:
                    if (moc_P_L - N > 0)
                        moc_P_L -= N;
                    else
                        moc_P_L = 0;

                    if (moc_P_P - N > 0)
                        moc_P_P -= N;
                    else
                        moc_P_P = 0;

                    if (moc_T_L - N > 0)
                        moc_T_L -= N;
                    else
                        moc_T_L = 0;

                    if (moc_T_P - N > 0)
                        moc_T_P -= N;
                    else
                        moc_T_P = 0;
                    break;

            }
            base.SendComend(myUart, moc_P_L, moc_P_P, moc_T_L, moc_T_P);
        }
        public void STOP()
        {           
            base.SendComend(myUart, 0, 0, 0, 0);

        }



        public void PrintEngineStatus()
        {
            Console.WriteLine("E1: " + moc_P_L + " E2: " + moc_P_P + " E3: " + moc_T_L + " E4: " + moc_T_P);
        }

        public override void readMessage(byte[] message)
        {
            if (message[0] == typ)
            {
                moc_P_L = message[1];
                moc_P_P = message[2];
                moc_T_L = message[3];
                moc_T_P = message[4];
            }
           // GUI.SetEnginePower(moc_P_L, moc_P_P, moc_T_L, moc_T_P);
        }
        public void manualON() { manual = true; }
        public void manualOFF() { manual = false; }

        public bool getManualState() { return manual; }
    };
}
