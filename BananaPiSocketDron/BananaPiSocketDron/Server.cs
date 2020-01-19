using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BananaPiSocketDron
{ 
    public class Server
    {
        private TcpListener serverSocket;
        TcpClient clientSocket = default(TcpClient);
        TcpClient lastClient = null;
        UART uart;

        

        public Server(UART uart) => this.uart = uart;

        public void start()
        {
            serverSocket = new TcpListener(IPAddress.Any, 11000);
            Console.WriteLine("Server starting...");
            byte[] bytesFrom = new byte[6];
            serverSocket.Start();

            while (true)
            {
                Console.WriteLine("Oczekiwanie na klienta");
                clientSocket = serverSocket.AcceptTcpClient();
                
                try
                {
                    while ((true))
                    {
                            NetworkStream networkStream = clientSocket.GetStream();
                            networkStream.Read(bytesFrom, 0, 6);
                            DebugMode.PrintOnConsole(bytesFrom);
                            uart.sendMessage(bytesFrom, bytesFrom.Length);
                    }
                }
                catch
                {
                    Console.WriteLine("Błąd połączenia");
                }
            }
        }
        public void send(Byte[] message)
        {
            while (lastClient == null)
            {
                Console.WriteLine("Oczekiwanie na kienta");
                Thread.Sleep(10);
            }
            NetworkStream clientStream = clientSocket.GetStream();
            clientStream.Write(message, 0, message.Length);
            clientStream.Flush();
        }

    }
}
