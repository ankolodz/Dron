using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Client
    {
        Machine machine;
        TcpClient clientSocked = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);


        public void init(Machine machine)
        {
            this.machine = machine;
            clientSocked.Connect("127.0.0.1", 11000);
            serverStream = clientSocked.GetStream();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }
        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocked.GetStream();
                byte[] messageArr = new byte[6];
                serverStream.Read(messageArr, 0, 6);
                machine.messageHandler(messageArr);

            }
        }
        public void sendMessage(byte[] message,int size)
        {
            serverStream.Write(message, 0, size);
        }
    }
}

