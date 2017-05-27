using MyGolfSocietyApp.Competition;
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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

       

        private void btnAddNewCompetition_Click(object sender, EventArgs e)
        {
            AddNewCompetition addCompetition = new AddNewCompetition();
            addCompetition.ShowDialog();
        }

        private void btnListPlayers_Click(object sender, EventArgs e)
        {
            ListPlayers listPlayers = new ListPlayers();
            listPlayers.ShowDialog();
        }

        private void ListCoursesButton_Click(object sender, EventArgs e)
        {
            ListCourses listCourses = new ListCourses();
            listCourses.ShowDialog();
        }

        private void btnListCompetitions_Click(object sender, EventArgs e)
        {
            ListCompetitions listCompetitions = new ListCompetitions();
            listCompetitions.ShowDialog();
        }
    }
}
