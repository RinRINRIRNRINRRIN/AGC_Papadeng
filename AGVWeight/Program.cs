using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVWeight
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] processes = Process.GetProcessesByName("AGVWeight");
            if (processes.Length > 1)
            {
                MessageBox.Show("มีโปรแกรมเปิดใช้งานอยู่แล้วไม่สามารถเปิดซ้อนกันได้", "โปรแกรมเปิดซ้ำกัน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
