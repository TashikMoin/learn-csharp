﻿using System.ServiceProcess;
using System.Timers;

namespace WindowsService_Tutorial
{
    // click view code source to view code of service file

    public partial class Service : ServiceBase
    {
        /*
         *                                  How to start this service?
         - Go to design file 
         - Right click
         - Add installer
         - It will create ProjectInstaller which will contain two things (1. ServiceInstaller 2. ServiceProcessInstaller)
         - Go to properties of Service Installer, Give name to this service, starting mode (manual, auto) etc.
         - Go to properties of Service Process Installer, Change Account Type From USER --> "LocalSystem" 
           because this service will be executed on local system.
         - Click start button to build the service
         - Open project folder, go to bin>debug, an executable file of this service will be created after the 
           build in the debug folder.
         - Copy path of the debug folder
         - Open CMD as Administrator, change the directory --> "C:\> cd Windows\Microsoft.NET\Framework\v4.0.30319"
         - write installutil -i <path_to_service_executablefile_in_debug_folder>
           example, 
         - if we want to delete the service, use -u flag instead of -i
         - open run and type services.msc and check the service in windows services list.
         - start the service and see the log folders and files.
         - This service will create a new file on each day/date and in each file of a day it will write 
           something after 10 seconds.
        */
        private System.Timers.Timer Timer_Object;
        public Service()
        {
            InitializeComponent();
            Timer_Object = null;
        }

        protected override void OnStart(string[] args)
        {
            // autogenerated default service start function that executes whenever the service starts
            this.Timer_Object = new System.Timers.Timer();
            this.Timer_Object.Interval = 10000;
            this.Timer_Object.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Event);
            this.Timer_Object.Enabled = true;
            Log_Class.Write_Logs("Logs For This Event Are Successfully Written.");

        }

        private void Timer_Event(object sender, ElapsedEventArgs e)
        {
            // service logic here that will execute on service start function
            Log_Class.Write_Logs("Timer Event Triggered To Perform Some Task");
            Log_Class.Write_Logs("... Performing Some Task ...");
            Log_Class.Write_Logs("... Ending Task ...");
        }

        protected override void OnStop()
        {
            // autogenerated default service stop function that executes whenever the service ends
            Log_Class.Write_Logs("... Stopping The Service ...");
            Timer_Object.Stop();
        }

    }
}
