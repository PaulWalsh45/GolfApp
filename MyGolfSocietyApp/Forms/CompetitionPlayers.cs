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

namespace MyGolfSocietyApp.Forms
{
    public partial class CompetitionPlayers : Form
    {
        private GolfAppEntities _dbLookUp = new GolfAppEntities();
        private List<Player> _players = new List<Player>();
        private List<Player> _classOne = new List<Player>();
        private List<Player> _classTwo = new List<Player>();
        private List<Player> _classThree = new List<Player>();

        private int _class1Max, _class2Max, _class3Max;
        public int _playersCount;
        public int _class1Count;
        public int _class2Count;
        public int _class3Count;

        private List<Player> _selectedPlayers = new List<Player>();

        public CompetitionPlayers(int numClasses, int class1Max, int class2Max, int class3Max)//, out int playersCount, out int class2Count, out int class3Count)
        {
            _class1Max = class1Max;
            _class2Max = class2Max;
            _class3Max = class3Max;
            _playersCount = 0;
            _class1Count = 0;
            _class2Count = 0;
            _class3Count = 0;
            


            InitializeComponent();
            PopulateGrid();
            ConfigureClassGrids(numClasses);
            
        }

        #region Functions

        private void ConfigureClassGrids(int classes)
        {
            
            Class1DGV.Visible = true;
            Class2DGV.Visible = true;
            Class3DGV.Visible = true;
            Class1GroupBox.Visible = true;
            Class2GroupBox.Visible = true;
            Class3GroupBox.Visible = true;

            if (classes == 0 || classes == 1)
            {
                Class1DGV.Visible = false;
                Class2DGV.Visible = false;
                Class3DGV.Visible = false;
                Class1GroupBox.Visible = false;
                Class2GroupBox.Visible = false;
                Class3GroupBox.Visible = false;
            }
            else if (classes == 2)
            {
                Class3DGV.Visible = false;
                Class3GroupBox.Visible = false;
            }          
                
        }
        
        private void PopulateGrid()
        {
            _players = _dbLookUp.Players.OrderBy(o => o.LAST_NAME).ToList();
            PlayersBindingSource.DataSource = _players;

        }

        private void UpdateGrids()
        {
            PopulateClassOneGrid();
            PopulateClassTwoGrid();
            PopulateClassThreeGrid();
            _playersCount = _class1Count + _class2Count + _class3Count;
        }

        
        private void PopulateClassOneGrid()
        {
            var bindingList = new BindingList<Player>(_classOne);
            _class1Count = _classOne.Count;//populate footer summary labels for calling form 
            Class1DGV.DataSource = bindingList.Select(o => new MyViewModel(o)
            { Name = o.FULLNAME, Handicap = o.HANDICAP }).ToList();
            Class1DGV.ReadOnly = true;
            Class1DGV.RowHeadersVisible = false;
          
        }

        private void PopulateClassTwoGrid()
        {
            var bindingList = new BindingList<Player>(_classTwo);
            _class2Count = _classTwo.Count; //populate footer summary labels for calling form 
            Class2DGV.DataSource = bindingList.Select(o => new MyViewModel(o)
            { Name = o.FULLNAME, Handicap = o.HANDICAP }).ToList();
            Class2DGV.ReadOnly = true;
            Class2DGV.RowHeadersVisible = false;
        }

        private void PopulateClassThreeGrid()
        {
            var bindingList = new BindingList<Player>(_classThree);
            _class3Count = _classThree.Count; //populate footer summary labels for calling form 
            Class3DGV.DataSource = bindingList.Select(o => new MyViewModel(o)
            { Name = o.FULLNAME, Handicap = o.HANDICAP }).ToList();
            Class2DGV.ReadOnly = true;
            Class3DGV.RowHeadersVisible = false;
        }

        #endregion

        #region Event Handlers

        // selecting/unselecting a player in the main grid will populate/unpopulate the Class grids
        private void CompetitionPlayersDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == Select.Index && e.RowIndex != -1)
            {
                
                Player player = (Player)CompetitionPlayersDGV.Rows[e.RowIndex].DataBoundItem;
                DataGridViewRow row = CompetitionPlayersDGV.SelectedRows[0];
                var selected = Convert.ToBoolean(row.Cells["Select"].Value);

                if (selected && player.HANDICAP <= _class1Max)
                {
                    _classOne.Add(player);
                }
                else if (!selected && _classOne.Contains(player))
                {
                    _classOne.Remove(player);
                }
                else if (selected && player.HANDICAP <= _class2Max)
                {
                    _classTwo.Add(player);
                }
                else if (!selected && _classTwo.Contains(player))
                {
                    _classTwo.Remove(player);
                }
                else if (selected && player.HANDICAP <= _class3Max)
                {
                    _classThree.Add(player);
                }
                else if (!selected && _classThree.Contains(player))
                {
                    _classThree.Remove(player);
                }

                UpdateGrids();

            }
        }

        private void Class2DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //to tell checkbox its done editing when clicked
        private void CompetitionPlayersDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Select.Index && e.RowIndex != -1)
            {
                CompetitionPlayersDGV.EndEdit();
            }
        }


        #endregion

        #region Inner Class

        class MyViewModel
        {
            public string Name { get; set; }
            public int? Handicap { get; set; }

            private Player _obj;

            public MyViewModel(Player obj)
            {
                _obj = obj;
            }

            public Player GetModel()
            {
                return _obj;
            }

        }

        #endregion
    }
    
}
