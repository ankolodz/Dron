using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UART myUart = new UART();
            //myUart.initCOM();
                       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Client client = new Client();
            Machine machine = new Machine(client);
            

            Form1 form = new Form1();



            client.init(machine);
            form.setMachine(machine);


            Application.Run(form);
            Console.WriteLine("start listen");

            
        }
    }
}