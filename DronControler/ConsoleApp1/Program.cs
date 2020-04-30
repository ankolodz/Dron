using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            Client client = new Client(proxy);
            Machine machine = new Machine(proxy);

            GamePad gamepad = new GamePad(machine);
            gamepad.init();
 
            client.init();
            proxy.setUDP(client);
            proxy.setMachine(machine);

            Form1 form = new Form1();
            form.setProxy(proxy);

            Application.Run(form);
            Console.WriteLine("start program");
            gamepad.startLisiner();





        }
        //static void gamepad()
        //{


        //    acquire the joystick
        //    joystick.acquire();

        //    poll events from joystick
        //    while (true)
        //    {
        //        joystick.poll();
        //        var datas = joystick.getbuffereddata();
        //        foreach (var state in datas)
        //            console.writeline(state.forcex);
        //    }
        //}
    }
}