using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DronApp
{
    public class Client
    {
        Proxy proxy;
        TcpClient clientSocked;
        NetworkStream serverStream;

        public Client (Proxy proxy){
            this.proxy = proxy;
        }


        public void init()
        {
            int attempt = 1;
            do
            {
                try
                {
                    clientSocked = new TcpClient();
                    serverStream = default(NetworkStream);

                    clientSocked.Connect("localhost", 11000);
                    serverStream = clientSocked.GetStream();

                    Thread ctThread = new Thread(getMessage);
                    ctThread.Start();
                    break;
                }
                catch
                {
                    attempt++;
                    Console.WriteLine("Błąd połączenia" + attempt);
                    Thread.Sleep(attempt * 300);
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
                proxy.getMachine().messageHandler(messageArr);
                }
                catch
                {
                    init();
                    return;
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

