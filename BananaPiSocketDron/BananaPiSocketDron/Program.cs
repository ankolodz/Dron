using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaPiSocketDron
{
    class Program
    {
        static void Main(string[] args)
        {
            UART uart = new UART();
            Server server = new Server(uart);
            uart.initCOM(server);
            server.start();

        }
    }
}
