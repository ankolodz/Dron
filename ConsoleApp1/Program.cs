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
            UART myUart = new UART();
            myUart.initCOM();
                       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            Machine machine = new Machine(myUart, form);
            form.setMachine(machine);
            myUart.setMachine(machine);

            Application.Run(form);

            
        }
    }
}