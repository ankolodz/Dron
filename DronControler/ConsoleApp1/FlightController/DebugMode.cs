using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace DronApp
{
    public class DebugModule
    {
        private Queue<String> queue;

        public DebugModule()
        {
            this.queue = new Queue<String>();
        }

        public void addLog(Byte[] message)
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                            CultureInfo.InvariantCulture);
            this.queue.Enqueue(timestamp + " " + MessageLog(message));
        }

        public void addLog(string message)
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                CultureInfo.InvariantCulture);
            this.queue.Enqueue(timestamp + " " + message);
            saveToFile();           
        }

        public void saveToFile()
        {
            //StreamWriter SW = File.AppendText("./log" + DateTime.Now + ".txt");

            //foreach(String s in queue)
            //{
            //    SW.WriteLine(s);
            //}
            //SW.Close();
            //queue.Clear();
        }


        private string MessageLog (byte[] message)
        {
            string newLog = "";
            foreach (byte i in message){
                newLog += i + ", ";
            }
                return newLog ;
        }

        public static void PrintOnConsole(byte[] arr)
        {
            String text = "";
            foreach (byte i in arr)
            {
                text += i + " ";
            }
            Console.WriteLine(text);
        }

    }
}
