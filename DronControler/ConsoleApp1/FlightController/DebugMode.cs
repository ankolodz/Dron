using System;
using System.IO;

namespace DronApp
{
    static class DebugMode
    {
        public static void addLog(string message)
        {
            StreamWriter SW = File.AppendText("./log.txt");
            DateTime thisDay = DateTime.Today;

            SW.WriteLine(thisDay.ToString("D") + "  " + message);

        }
        public static void addLog(byte[] message)
        {
                    StreamWriter SW = File.AppendText("./log.txt");
            SW.WriteLine(MessageLog(message));
            SW.Close();
        }
        private static string MessageLog (byte[] message)
        {
            //DateTime thisDay = DateTime.Today;
            string newLog = "";
            foreach (byte i in message){
                newLog += i + ", ";
            }
             //= message; //thisDay.ToString("D")+"  "+message;
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
