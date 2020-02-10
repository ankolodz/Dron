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
        TcpClient clientSocked;
        NetworkStream serverStream;


        public void init(Machine machine)
        {
            this.machine = machine;
            this.connect();            
        }
        private void connect()
        {
            do
            {
                try
                {
                    clientSocked = new TcpClient();
                    serverStream = default(NetworkStream);

                    clientSocked.Connect("127.0.0.1", 11000);
                    serverStream = clientSocked.GetStream();

                    Thread ctThread = new Thread(getMessage);
                    ctThread.Start();
                    break;
                }
                catch
                {
                    Console.WriteLine("Błąd połączenia");
                }
            } while (true);

        }
        private void getMessage()
        {            
            while (true)
            {
                try
                {
                serverStream = clientSocked.GetStream();
                byte[] messageArr = new byte[6];
                serverStream.Read(messageArr, 0, 6);
                machine.messageHandler(messageArr);
                }
                catch
                {
                    connect();
                }
                

            }
        }
        public void sendMessage(byte[] message,int size)
        {
            try
            {
                serverStream.Write(message, 0, size);
            }
            catch
            {
                Console.WriteLine("Zgubiono wiadomosć");
                return;
            }
            
        }
    }
}

