using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DronApp.Comunication;
using DronApp.ControlManager;

namespace DronApp
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Proxy proxy = new Proxy();

            Client client = new UART(proxy);
            Machine machine = new Machine(proxy);

            iController controller = new GamePad(proxy, machine);
            controller.init();
   /*         if (!controller.init()){
                controller = new KeybordController(machine);
                controller.init();
            }*/

            

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