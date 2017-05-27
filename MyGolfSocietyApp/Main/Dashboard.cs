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

        

        

        private void menuViewPlayer_Click(object sender, EventArgs e)
        {

        }

        //private void menuNewPlayer_Click(object sender, EventArgs e)
        //{
        //    EditPlayer addNewPlayer = new EditPlayer();
        //    addNewPlayer.ShowDialog();
        //}

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void newOutingMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewCompetition newOuting = new AddNewCompetition();
            newOuting.ShowDialog();
        }

        //private void newCourseMenuItem_Click(object sender, EventArgs e)
        //{
        //    EditCourse addnewCourse = new EditCourse();
        //    addnewCourse.ShowDialog();
        //}

        private void listPlayersMenuItem_Click(object sender, EventArgs e)
        {
            ListPlayers listAllMembers = new ListPlayers();
            listAllMembers.ShowDialog();
        }
    }
}
