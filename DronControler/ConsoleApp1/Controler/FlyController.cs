using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1 

{
    public class FlyController : Unit
    {
        private const int ZERO = 40;
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
        public byte getThrotle() { return throtle; }
        public byte getVerticalDirection() { return verticalDirection; }
        public byte getHorizontalDirection() { return horizontalDirection; }


        public override void readMessage(byte[] message)
        {
            throw new NotImplementedException();
        }
        public void upThrotle(){
            if (throtle<255)
                this.throtle +=throtleStep;
            sendFlyController();
        }
        public void downThrotle()
        {
            if (throtle > 0)
                this.throtle -= throtleStep;
            sendFlyController();
        }
        public void downRudder()
        {
            if (this.verticalDirection < 80)         
                this.verticalDirection++;
            sendFlyController(); 
        }
        public void upRudder()
        {
            if (this.verticalDirection > 0)
                this.verticalDirection--;
            sendFlyController();
        }
        public void leftRudder()
        {
            if (this.horizontalDirection > 0)
                this.horizontalDirection--;
            sendFlyController();
        }
        public void rightRudder()
        {
            if (this.horizontalDirection < 80)
                this.horizontalDirection++;
            sendFlyController();
        }

        public void slowBackRudder()
        {
            if (horizontalDirection != ZERO)
                if (horizontalDirection > ZERO) horizontalDirection--;
                else horizontalDirection++;
            if (verticalDirection != ZERO)
                if (verticalDirection > ZERO) verticalDirection--;
                else verticalDirection--;
        }
        public void sendFlyController()
        {
            base.SendComend(client, throtle, verticalDirection, horizontalDirection, 0);
        }


        public void STOP()
        {
            throtle = 0;
            sendFlyController();

        }
        public byte getFlyController() { return throtle; }
    };
}
