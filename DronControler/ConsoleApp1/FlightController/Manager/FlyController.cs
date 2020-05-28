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

        private Throtle throtle = new Throtle();
        private SingleRudder verticalRudder;
        private SingleRudder horizontalRudder;
        private Proxy proxy;

        public FlyManager(Proxy p){
            this.proxy = p;
            this.throtle = new Throtle();
            this.verticalRudder = new SingleRudder();
            this.horizontalRudder = new SingleRudder();
        }

        public override byte getType() { return type;}
        public byte getThrotle() { return throtle.getState(); }
        public byte getVerticalDirection() { return verticalRudder.getState(); }
        public byte getHorizontalDirection() { return horizontalRudder.getState(); }


        public override void readMessage(byte[] message)
        {
            throw new NotImplementedException();
        }

        //***throtle***

        public void upThrotle(int N=5){
            throtle.up(N);
            base.isChange();
        }
        public void downThrotle(int N=5)
        {
            throtle.down(N);
            base.isChange();
        }
        public void setThrotle(int val)
        {
            throtle.set((Byte)val);
            base.isChange();
        }

        //***rudder***

        public void downRudder(){
            verticalRudder.down();
            base.isChange();
        }

        public void upRudder(){
            verticalRudder.up();
            base.isChange();
        }

        public void leftRudder(){
            horizontalRudder.down();
            base.isChange();
        }
        public void rightRudder(){
            horizontalRudder.up();
            base.isChange();
        }
        public void setHorizontal(int val)
        {
            horizontalRudder.set((byte)val);
            base.isChange();
        }
        public void setVertical(int val)
        {
            verticalRudder.set((byte)val);
            base.isChange();
        }


        public void sendFlyController(){
            base.SendComend(proxy, throtle.getState(), verticalRudder.getState(), horizontalRudder.getState(), 0);
        }

        public void STOP(){
            throtle.set( 0 );
            base.isChange();

        }
    };
}
