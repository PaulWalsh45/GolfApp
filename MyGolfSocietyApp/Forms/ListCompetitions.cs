using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace MyGolfSocietyApp.Competition
{
    public partial class ListCompetitions : Form
    {
        private GolfAppEntities _dbLookup = new GolfAppEntities();
        private List<DAL.Competition> _competitions = new List<DAL.Competition>();
        public ListCompetitions()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            //note breaking because TBL_COMPETITION changed
            // entity refresh req'd
            _competitions = _dbLookup.Competitions.ToList();
            CompetitionsBindingSource.DataSource = _competitions;
            //_competitions = _dbLookup.Competitions.ToList();
            //CompetitionsBindingSource.DataSource = _competitions;
        }
    }
}
