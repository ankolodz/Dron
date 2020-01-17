using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rudder :Unit
    {
        private int x = 0;
        private int y = 0;
        UART uart;

        public Rudder(UART u)
        {
            this.uart = u;
        }

        public override byte getType()
        {
            return 129;
        }

        public override void readMessage(byte[] message)
        {
            throw new NotImplementedException();
        }
        public void up() {
            y += 1;       
        }
        public void down()
        {
            y -= 1;
        }
        public void left()
        {
            x -= 1;
        }
        public void right()
        {
            x += 1;
        }
        public void slowBack()
        {
            if (x != 0)
                if (x > 0) x--;
                else x++;
            if (y != 0)
                if (y > 0) y--;
                else y--;
        }
    }
}
