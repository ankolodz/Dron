using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DronApp
{
    static class Program
    {
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Proxy proxy = new Proxy();

            Client client = new Client(proxy);
            Machine machine = new Machine(proxy);

            client.init();
            proxy.setUDP(client);
            proxy.setMachine(machine);

            Form1 form = new Form1();            
            form.setProxy(proxy);

            Application.Run(form);
            Console.WriteLine("start program");

            
        }
    }
}