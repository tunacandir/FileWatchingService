using System;
using System.IO;

namespace FileWatchingService
{
    public static class Logger
    {
        public static void Log(string message)
        {
            try
            {
                string _message = String.Format("{0} {1}", message, Environment.NewLine);
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "logFile.log", _message);
                //File.AppendAllText(Variables.LogPath + "logFile.log", _message);
            }
            catch (Exception ex)
            {
                //Implement logging on next version
            }
        }
    }
}