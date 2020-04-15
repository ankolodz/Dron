using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DronApp 

{
    public class FlyManager : Component
    {
        private byte type = 128;

        private Throtle throtle;
        private SingleRudder verticalDirection;
        private SingleRudder horizontalDirection;
        private Proxy proxy;

        public FlyManager(Proxy p)
        {
            this.proxy = p;
        }

        public override byte getType() { return type;}
        public byte getThrotle() { return throtle.getState(); }
        public byte getVerticalDirection() { return verticalDirection.getState(); }
        public byte getHorizontalDirection() { return horizontalDirection.getState(); }


        public override void readMessage(byte[] message)
        {
            throw new NotImplementedException();
        }

        //***throtle***

        public void upThrotle(){
            throtle.up();
            base.isChange();
        }
        public void downThrotle(){
            throtle.down();
            base.isChange();
        }

        //***rudder***

        public void downRudder(){
            verticalDirection.down();
            base.isChange();
        }

        public void upRudder(){
            verticalDirection.up();
            base.isChange();
        }

        public void leftRudder(){
            horizontalDirection.down();
            base.isChange();
        }
        public void rightRudder(){
            horizontalDirection.up();
            base.isChange();
        }


        public void sendFlyController(){
            base.SendComend(proxy, throtle.getState(), verticalDirection.getState(), horizontalDirection.getState(), 0);
        }

        public void STOP(){
            throtle.set( 0 );
            isChange();

        }
    };
}
