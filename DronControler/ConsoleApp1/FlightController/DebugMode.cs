using System;
using System.IO;

namespace DronApp
{
    static class DebugMode
    {
        public static void addLog(string message)
        {
            try
            {
                StreamWriter SW = File.AppendText("./log.txt");
                DateTime thisDay = DateTime.Today;

                SW.WriteLine(thisDay.ToString("D") + "  " + message);
                SW.Close();
            }
            catch
            {
                addLog(message);
            }
            

        }

        public static void addLog(byte[] message)
        {
            try
            {
                StreamWriter SW = File.AppendText("./log.txt");
                SW.WriteLine(MessageLog(message));
                SW.Close();
            }
            catch
            {
               addLog(message);
            }
        }

        private static string MessageLog (byte[] message)
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
