﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Machine
    {
        private UART myUART;
        public Engine engine;
        public Gyroscope gyroscope;
        public Throtle throtle;


        public Machine (UART uart)
        {
            this.myUART = uart;
            engine = new Engine(uart);
            gyroscope = new Gyroscope();
            throtle = new Throtle(uart);
        }
        public void messageHandler  (byte[] message)
        {
            Console.WriteLine(message[0]+" "+message[1]);
            switch (message[0])
            {
                case 1:
                    engine.readMessage(message);
                    break;
                case 2:
                    gyroscope.readMessage(message);
                    break;
            }
        }
        public void STOP()
        {
            engine.STOP();
        }

        
    }
}
