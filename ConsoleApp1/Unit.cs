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
        public void SendComend(UART MyComPort, byte part1, byte part2, byte part3, byte part4)
        {
            byte[] byteMessage = new byte[5];
            byteMessage[0] = getType();
            byteMessage[1] = part1;
            byteMessage[2] = part2;
            byteMessage[3] = part3;
            byteMessage[4] = part4;

            MyComPort.sendMessage(byteMessage, 5);
        }
    }
}
