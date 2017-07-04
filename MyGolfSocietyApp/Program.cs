using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGolfSocietyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Licience licience = new Licience();
            if (licience.Active)
            {
                Application.Run(new Test());//for dev
                //Application.Run(new Form1());// for Live
            }
            else
            {
                MessageBox.Show("Your licience has expired"
                                +Environment.NewLine
                                +"Please contact 087-7727879 for renewal",
                                "Licience Status",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }
    }
}
