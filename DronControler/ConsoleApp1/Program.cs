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

            Proxy proxy;

            Client client = new Client(proxy);
            Machine machine = new Machine(proxy);

            proxy.setUDP(client);
            proxy.registerMachine(machine);

            Form1 form = new Form1();



            client.init(machine);
            form.setMachine(machine);


            Application.Run(form);
            Console.WriteLine("start listen");

            
        }
    }
}