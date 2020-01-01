using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 

{
    public class Throtle : Unit
    {
        private byte type = 128;
        private byte throtle = 0;
        UART uart;

        public Throtle(UART u)
        {
            this.uart = u;
        }
        public override byte getType()
        {
            return type;
        }

        public override void readMessage(byte[] message)
        {
            throw new NotImplementedException();
        }
        public void upThrotle()
        {   if (throtle<255)
                this.throtle +=1;
            base.SendComend(uart, throtle, 0, 0, 0);
        }
        public void downThrotle()
        {
            if (throtle > 0)
                this.throtle -= 1;
            base.SendComend(uart, throtle, 0, 0, 0);
        }
        public void sendThrotle()
        {
            base.SendComend(uart, throtle, 0, 0, 0);
        }
        public void STOP()
        {
            throtle = 0;
            base.SendComend(uart, throtle, 0, 0, 0);

        }
        public void sendThrotleStatr()
        {
            base.SendComend(uart, throtle, 0, 0, 0);
        }
        public byte getThrotle() { return throtle; }
    };
}
