using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        private static void writeMenu()
        {
            Console.WriteLine("Podaj współrzędne");
        }
        static void Main(string[] args)
        {
            UART myComPort = new UART();
            myComPort.initCOM();
            Form1 form = new Form1();
            Machine machine = new Machine(myComPort, form);
            form.setMachine(machine);

            form.Visible = true;


            while (true)
            {
                Thread.Sleep(200);
            }

            // Engine myEngineData = new Engine(myComPort);
            //Console.WriteLine("Q - all engine up   A-all engine down Z-STOP");
            //Console.WriteLine("WERT - 1,2,3,4 engine up SDFG - 1,2,3,4 engine down");
            //ConsoleKeyInfo pressKey;
            //while (true)
            //{
            //    pressKey = Console.ReadKey();
            //    switch (pressKey.Key)
            //    {
            //        case ConsoleKey.Q:
            //            myEngineData.upEnginePower(5);

            //            break;
            //        case ConsoleKey.A:
            //            myEngineData.downEnginePower(5);

            //            break;
            //        case ConsoleKey.Z:
            //            myEngineData.STOP();
            //            break;
            //        case ConsoleKey.W:
            //            myEngineData.upEnginePower(1);
            //            break;
            //        case ConsoleKey.E:
            //            myEngineData.upEnginePower(2);
            //            break;
            //        case ConsoleKey.R:
            //            myEngineData.upEnginePower(3);
            //            break;
            //        case ConsoleKey.T:
            //            myEngineData.upEnginePower(4);
            //            break;
            //        case ConsoleKey.S:
            //            myEngineData.downEnginePower(1);
            //            break;
            //        case ConsoleKey.D:
            //            myEngineData.downEnginePower(2);
            //            break;
            //        case ConsoleKey.F:
            //            myEngineData.downEnginePower(3);
            //            break;
            //        case ConsoleKey.G:
            //            myEngineData.downEnginePower(4);
            //            break;
            //    }
            //    myEngineData.PrintEngineStatus();


            //    Thread.Sleep(200);
            //}

            myComPort.end();

        }
    }

}
