using MyGolfSocietyApp.Competition;
using MyGolfSocietyApp.Forms;
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
            SetLicienceLabel();

        }

        #region Functions

        private void SetLicienceLabel()
        {
            Licience licience = new Licience();
            licienceLabel.Text = "Your licience is valid until " + licience.ExpiryDate;
        }

        #endregion

        #region Buttons

        private void btnAddNewCompetition_Click(object sender, EventArgs e)
        {
            AddNewCompetition addCompetition = new AddNewCompetition();
            addCompetition.StartPosition = FormStartPosition.CenterScreen;
            addCompetition.ShowDialog();
        }

        private void btnListPlayers_Click(object sender, EventArgs e)
        {
            ListPlayers listPlayers = new ListPlayers();
            listPlayers.StartPosition = FormStartPosition.CenterScreen;
            listPlayers.ShowDialog();
        }

        private void ListCoursesButton_Click(object sender, EventArgs e)
        {
            ListCourses listCourses = new ListCourses();
            listCourses.StartPosition = FormStartPosition.CenterScreen;
            listCourses.ShowDialog();
        }

        private void btnListCompetitions_Click(object sender, EventArgs e)
        {
            ListCompetitions listCompetitions = new ListCompetitions();
            listCompetitions.StartPosition = FormStartPosition.CenterScreen;
            listCompetitions.ShowDialog();
        }

        private void SmsButton_Click(object sender, EventArgs e)
        {
            SMS sms = new SMS();
            sms.StartPosition = FormStartPosition.CenterScreen;
            sms.ShowDialog();
            
        }

        #endregion


    }
}
