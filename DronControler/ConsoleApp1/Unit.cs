using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Unit
    {
       
        public abstract byte getType();
        public abstract void readMessage(byte[] message);
        public void SendComend(Client MyComPort, byte part1, byte part2, byte part3, byte part4)
        {
            byte[] byteMessage = new byte[6];
            byteMessage[0] = getType();
            byteMessage[1] = part1;
            byteMessage[2] = part2;
            byteMessage[3] = part3;
            byteMessage[4] = part4;
            byteMessage[5] = Convert.ToByte((getType() + part1 + part2 + part3 +part4)% 256);

            MyComPort.sendMessage(byteMessage, 6);
        }
    }
}
