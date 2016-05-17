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
            AddNewCourse addnewCourse = new AddNewCourse();
            addnewCourse.ShowDialog();
        }

        

        private void menuViewPlayer_Click(object sender, EventArgs e)
        {

        }

        private void menuNewPlayer_Click(object sender, EventArgs e)
        {
            AddNewPlayer addNewPlayer = new AddNewPlayer();
            addNewPlayer.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
