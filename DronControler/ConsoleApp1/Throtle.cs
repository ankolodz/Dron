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
        Client client;
        private byte step = 5;

        public Throtle(Client u)
        {
            this.client = u;
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
                this.throtle +=step;
            base.SendComend(client, throtle, 0, 0, 0);
        }
        public void downThrotle()
        {
            if (throtle > 0)
                this.throtle -= step;
            base.SendComend(client, throtle, 0, 0, 0);
        }
        public void sendThrotle()
        {
            base.SendComend(client, throtle, 0, 0, 0);
        }
        public void STOP()
        {
            throtle = 0;
            base.SendComend(client, throtle, 0, 0, 0);

        }
        public void sendThrotleStatr()
        {
            base.SendComend(client, throtle, 0, 0, 0);
        }
        public byte getThrotle() { return throtle; }
    };
}
