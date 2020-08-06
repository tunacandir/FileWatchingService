using FileWatchingService;
using System;
using System.Windows.Forms;

namespace PathChooser
{
    public partial class Form1 : Form
    {
        public static Form1 form = new Form1();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Variables.FilePath = folderBrowserDialog1.SelectedPath;
            textBox1.Text = Variables.FilePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            Variables.LogPath = folderBrowserDialog2.SelectedPath;
            textBox2.Text = Variables.LogPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
#if DEBUG
            Service1 s = new Service1();
            s.OnDebug();

            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else
            form.Close();
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
