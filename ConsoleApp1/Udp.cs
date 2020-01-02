using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Udp
    {
        private UdpClient udpClient;
        private Machine machine;
        public Udp(String ip, Machine machine)
        {
            udpClient = new UdpClient(ip, 12000);
            this.machine = machine;

        }

        public void send(byte[] sendBytes)
        {
            udpClient.Send(sendBytes, sendBytes.Length);
        }
        public void Lisiner()
        {
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receivedBytes = udpClient.Receive(ref RemoteIpEndPoint);
                machine.messageHandler(receivedBytes);
                Console.Write(receivedBytes[0] + receivedBytes[1]);

            }
        }

    }
}
