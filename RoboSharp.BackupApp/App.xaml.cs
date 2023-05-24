using RoboSharp.BackupApp.Win32Job;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RoboSharp.BackupApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        JobObject job;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Create the Job object and assign it to the current process
            job = new JobObject();

            job.SetLimits(new JobObjectLimits()
            {
                Flags = JobObjectLimitFlags.DieOnUnhandledException |
                        JobObjectLimitFlags.KillOnJobClose,
            });

            job.AssignProcess(Process.GetCurrentProcess());
        }
    }
}
