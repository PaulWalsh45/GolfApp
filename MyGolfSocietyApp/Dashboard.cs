using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGolfSocietyApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCourse addnew = new AddNewCourse();
            addnew.ShowDialog();
        }

        

        private void menuViewPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
