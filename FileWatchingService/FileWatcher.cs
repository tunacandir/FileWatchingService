using System;
using System.IO; // Filesystemwatcher bunun içerisinde bulunuyor.

namespace FileWatchingService
{
    public class FileWatcher
    {
        private readonly FileSystemWatcher _fileWatcher; //_fileWatcher isminde bir dosya okuyucu belirliyoruz

        public FileWatcher()
        {
            _fileWatcher = new FileSystemWatcher(PathLocation()); 
            _fileWatcher.Created += _fileWatcher_Created;
            _fileWatcher.Renamed += _fileWatcher_Renamed;
            _fileWatcher.Deleted += _fileWatcher_Deleted;
            _fileWatcher.Changed += _fileWatcher_Changed;
            _fileWatcher.IncludeSubdirectories = true;
            _fileWatcher.EnableRaisingEvents = true;
        }
        
        private string PathLocation()
        {
            var value = "";
            try
            {
                //value = ConfigurationManager.AppSettings.Get("location");
                //value = Environment.GetFolderPath(Environment.SpecialFolder.Recent);

                value = Variables.FilePath;
            }
            catch (Exception ex)
            {
            }
            return value;
        }

        private void _fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("File Changed: Path:{0}, Name:{1} \n", e.FullPath, e.Name));
        }

        private void _fileWatcher_Renamed(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("File Renamed: Path:{0}, Name:{1}", e.FullPath, e.Name));
        }

        private void _fileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("File Deleted: Path:{0}, Name:{1}", e.FullPath, e.Name));
        }

        private void _fileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("File Created: Path:{0}, Name:{1}", e.FullPath, e.Name));
        }
    }
}