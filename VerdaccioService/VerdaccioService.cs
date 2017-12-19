using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VerdaccioService
{
    public partial class VerdaccioService : ServiceBase
    {

        private Process process;
        private Timer timer;

        public VerdaccioService()
        {
            InitializeComponent();

        }

        protected override void OnStart(string[] args)
        {

            var info = new ProcessStartInfo(@"C:\Users\ftavares\AppData\Roaming\npm\verdaccio.cmd");
            info.UseShellExecute = false;
            info.RedirectStandardError = true;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.CreateNoWindow = true;
            info.ErrorDialog = false;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            process = Process.Start(info);


            timer = new Timer(60 * 1000);
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;

            timer.Start();
            
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }

        protected override void OnStop()
        {
            process.Kill();
        }



    }
}
