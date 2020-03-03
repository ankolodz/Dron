using System;
using System.IO;

namespace ConsoleApp1
{
    static class DebugMode
    {
        public static void addLog(string message)
        {
            StreamWriter SW = File.AppendText("./log.txt");
            SW.WriteLine(MessageLog(message));
            SW.Close();
        }
        private static string MessageLog (string message)
        {
            DateTime thisDay = DateTime.Today;
            string newLog = thisDay.ToString("D")+"  "+message;
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
