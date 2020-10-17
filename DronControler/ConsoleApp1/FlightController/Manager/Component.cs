using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronApp
{
    public abstract class Component
    {
        private bool change;

        public abstract byte getType();

        public abstract void readMessage(byte[] message);

        public void SendComend(Proxy proxy, byte part1, byte part2, byte part3, byte part4)
        {
            byte[] byteMessage = new byte[6];
            byteMessage[0] = getType();
            byteMessage[1] = part1;
            byteMessage[2] = part2;
            byteMessage[3] = part3;
            byteMessage[4] = part4;
            byteMessage[5] = Convert.ToByte((getType() + part1 + part2 + part3 +part4)% 256);

            proxy.GetMessageService().newMessage(byteMessage, SenderId.MESSAGE);
        }
        public void isChange(){
            change = true;
        }

        public bool toSend(){
            if ( change ){
                change = false;
                return true;
            }
            return false;
        }
    }
}
