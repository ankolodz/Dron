using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1 

{
    public class FlyController : Unit
    {
        private const int ZERO = 20;
        private byte type = 128;
        private byte throtle = 0;
        private byte verticalDirection = ZERO;
        private byte horizontalDirection = ZERO;
        Client client;
        private byte throtleStep = 5;

        public FlyController(Client c)
        {
            this.client = c;
        }
        public override byte getType() { return type;}

        public override void readMessage(byte[] message)
        {
            throw new NotImplementedException();
        }
        public void upThrotle(){
            if (throtle<255)
                this.throtle +=throtleStep;
            base.SendComend(client, throtle, 0, 0, 0);
        }
        public void downThrotle()
        {
            if (throtle > 0)
                this.throtle -= throtleStep;
            base.SendComend(client, throtle, 0, 0, 0);
        }


        public void sendFlyController()
        {
            base.SendComend(client, throtle, verticalDirection, horizontalDirection, 0);
        }
        public void slowBack()
        {
            if (horizontalDirection != 0)
                if (horizontalDirection > 0) horizontalDirection--;
                else horizontalDirection++;
            if (verticalDirection != 0)
                if (verticalDirection > 0) verticalDirection--;
                else verticalDirection--;
        }
        public void STOP()
        {
            throtle = 0;
            base.SendComend(client, throtle, 0, 0, 0);

        }
        public byte getFlyController() { return throtle; }
    };
}
