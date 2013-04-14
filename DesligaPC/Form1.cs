using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesligaPC.Properties;
using System.Management; 

namespace DesligaPC
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            DateTime horaDesligar = Convert.ToDateTime(Settings.Default.HoraDesligar);
            
            t.Interval = 100;
            t.Start();

            t.Tick += (a, b) =>
            {
                if (DateTime.Now >= horaDesligar)
                {
                    Shutdown();
                    //Process.Start("shutdown", "-l -f"); 
                    t.Stop();
                }
                else
                {
                    TimeSpan tempo = (horaDesligar.TimeOfDay - DateTime.Now.TimeOfDay).Duration();
                    lbTempo.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", new object[] {
                            tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds});
                    lbTempo.Refresh();
                }
            };
        }

        private void btNaoDesligue_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Shutdown()
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();
            // You can't shutdown without security privileges 
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");
            // Flag 1 means we want to shut down the system. Use "2" to reboot. 
            mboShutdownParams["Flags"] = "1";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        } 
    }
}
