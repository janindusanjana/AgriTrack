using System;
using System.Windows.Forms;
using AgriTrack.Admin_Forms;

namespace AgriTrack
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
             https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Settlement_UI());
        }
    }
}