using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using VirtualDesktopGridSwitcher.Settings;

namespace VirtualDesktopGridSwitcher 
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            // sometimes during startup it fails to init properly, so adding a slight delay
            Thread.Sleep(TimeSpan.FromSeconds(5));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settings = SettingValues.Load();
            using (var sysTrayProcess = new SysTrayProcess(settings)) 
            {
                using (var gridManager =
                            new VirtualDesktopGridManager(sysTrayProcess, settings)) 
                {

                    sysTrayProcess.SetClickSwitchHandler(gridManager.Switch);

                    // Make sure the application runs!
                    Application.Run();
                }

            }
        }
    
    }
}
