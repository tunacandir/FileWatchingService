using System.ServiceProcess;

namespace FileWatchingService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            FileWatcher f = new FileWatcher();
        }

        protected override void OnStop()
        {
        }
    }
}
