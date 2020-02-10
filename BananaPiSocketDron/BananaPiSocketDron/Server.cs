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
        private TcpClient clientSocket = default(TcpClient);
        private TcpClient lastClient = null;
        private UART uart;
        private int socketLife;

        

        public Server(UART uart) => this.uart = uart;

        public void start()
        {
            serverSocket = new TcpListener(IPAddress.Any, 11000);
            Console.WriteLine("Server starting...");
            serverSocket.Start();

            while (true)
            {
                Console.WriteLine("Oczekiwanie na klienta");
                clientSocket = serverSocket.AcceptTcpClient();
                lastClient = clientSocket;
                Thread sockedChild = new Thread(new ThreadStart(this.LisiningSocket));
                sockedChild.Start();
                socketLife = 10;
                try
                {
                    while ((true))
                    {
                        if (socketLife <= 0)
                        {
                            Console.WriteLine("Brak komunikacji");
                            sockedChild.Abort();
                            lastClient = null;
                            break;
                        }
                        socketLife--;
                        Console.WriteLine("Socked decramented " + socketLife);
                        Thread.Sleep(5000);
                    }
                }
                catch
                {
                    Console.WriteLine("Błąd połączenia");
                }
            }
        }
        private void LisiningSocket()
        {
            Console.WriteLine("Nowy kontroler - połączono");
            byte[] bytesFrom = new byte[6];
            while (true)
            {
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, 6);
                DebugMode.PrintOnConsole(bytesFrom);
                uart.sendMessage(bytesFrom, bytesFrom.Length);
                socketLife = 5;
                Console.WriteLine("Socked add life " + socketLife);
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
