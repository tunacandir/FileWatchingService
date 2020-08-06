using System.Configuration;

namespace FileWatchingService
{
    public static class Variables
    {
        public static string FilePath { get; set; } = ConfigurationManager.AppSettings.Get("location");
        public static string LogPath { get; set; } = ConfigurationManager.AppSettings.Get("logLocation");
    }
}
