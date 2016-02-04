using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Threading;
using System.IO;

namespace Udemy_Windows_Service
{
    public partial class UdemyWindowsService : ServiceBase
    {
        ILog mLogger;
        Timer mRepeatingTimer;
        FileSystemWatcher fsw;

        double mCounter;
        public UdemyWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Udemy Windows Service is starting", EventLogEntryType.Information);
            ConfigureLog4Net();

            int i = 0;
            //System.Diagnostics.Debugger.Launch();
            do
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Value of i is: {0}", i));
                mLogger.Debug(string.Format("Value of i is: {0}", i));
            } while (i++ < 5);

            mLogger.Error("This is an error");

            //this comes from the project settings file
            int nTimerDelay = Properties.Settings.Default.TimerDelay;
            mLogger.Debug(string.Format("Value of TimerDelay is: {0}", nTimerDelay));
            mRepeatingTimer = new Timer(myTimerCallback, mRepeatingTimer, nTimerDelay, nTimerDelay);

            //first time it's fired
            //second time the timer tick

            fsw = new FileSystemWatcher(@"C:\csharp\AdvancedCSharp\Udemy Windows Service\bin\Debug\Watch Me");
            fsw.EnableRaisingEvents = true;
            fsw.IncludeSubdirectories = true;

            fsw.Created += Fsw_Created;
            fsw.Changed += Fsw_Changed;

        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            mLogger.Debug(string.Format("File changed" + e.FullPath));
            
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            mLogger.Debug(string.Format("File created" + e.FullPath));

            
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Udemy Windows Service is stopping", EventLogEntryType.Information);
        }

        private void ConfigureLog4Net()
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                mLogger = LogManager.GetLogger("servicelog");
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }

        public void myTimerCallback(object objParam)
        {
            mLogger.Debug(string.Format("Checking for work... RUN:" + ++mCounter));
            System.Diagnostics.Debug.WriteLine(string.Format("Value of i is: {0}", mCounter));
        }
    }
}
