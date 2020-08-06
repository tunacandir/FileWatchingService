using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatchingService
{
    public static class Variables
    {
        public static string FilePath { get; set; } = ConfigurationManager.AppSettings.Get("location");
    }
}
