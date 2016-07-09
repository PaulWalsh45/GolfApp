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

namespace MyGolfSocietyApp
{
    public partial class ListPlayers : Form
    {
        private BindingSource bindingSource = new BindingSource();
        GetData getPlayers = new GetData();

        public ListPlayers()
        {
            InitializeComponent();
            bindingSource.DataSource = getPlayers.GetPlayersFromDbForListPlayersDatagrid();
            dgvPlayers.DataSource = bindingSource;
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RenameColumHeadersInPlayersDataGridView();
        }

        private void RenameColumHeadersInPlayersDataGridView()
        {
            this.dgvPlayers.Columns["PlayerId"].HeaderText = "ID";
            this.dgvPlayers.Columns["PlayerFirstName"].HeaderText = "First Name";
            this.dgvPlayers.Columns["PlayerLastName"].HeaderText = "Last Name";
            this.dgvPlayers.Columns["PlayerHandicap"].HeaderText = "Handicap";
            this.dgvPlayers.Columns["PlayerAdjust"].HeaderText = "Adjust";
            this.dgvPlayers.Columns["PlayerJoinDate"].HeaderText = "Join Date";
        }
    }
}
