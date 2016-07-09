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
    public partial class AddNewOuting : Form
    {
        public AddNewOuting()
        {
            InitializeComponent();
            cbxClasses.SelectedIndex = 0;
            txtClassOneMin.Text = "0";
        }

        private void cbxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                var classes = cbxClasses.SelectedIndex;


            switch (classes)
            {
                case 0: HideAllClassUiElements(); break;
                case 1: ShowElementsForTwoClasses(); break;
                case 2: ShowElementsForThreeClasses(); break;

                default: 
                    break;
            }
        }

        public void HideAllClassUiElements()
        {
            lblClass1Min.Visible = false;
            lblClass1Max.Visible = false;
            lblClass1.Visible = false;
            lblClass2Min.Visible = false;
            lblClass2Max.Visible = false;
            lblClass2.Visible = false;
            lblClass3Min.Visible = false;
            lblClass3Max.Visible = false;
            lblClass3.Visible = false;
            txtClassOneMin.Visible = false;
            cbxClassOneMax.Visible = false;
            txtClassTwoMin.Visible = false;
            cbxClassTwoMax.Visible = false;
            txtClassThreeMin.Visible = false;
            cbxClassThreeMax.Visible = false;
            lblClassOnePlayers.Text = "Players";
            lblClassTwoPlayers.Visible = false;
            dgvClass2.Visible = false;
            lblClassThreePlayers.Visible = false;
            dgvClass3.Visible = false;


        }

        public void ShowElementsForTwoClasses()
        {
            lblClass1Min.Visible = true;
            lblClass1Max.Visible = true;
            lblClass1.Visible = true;
            lblClass2Min.Visible = true;
            lblClass2Max.Visible = true;
            lblClass2.Visible = true;
            lblClass3Min.Visible = false;
            lblClass3Max.Visible = false;
            lblClass3.Visible = false;
            txtClassOneMin.Visible = true;
            cbxClassOneMax.Visible = true;
            txtClassTwoMin.Visible = true;
            cbxClassTwoMax.Visible = true;
            txtClassThreeMin.Visible = false;
            cbxClassThreeMax.Visible = false;
            lblClassOnePlayers.Visible = true;
            lblClassOnePlayers.Text = "Class 1 Players";
            lblClassTwoPlayers.Visible = true;
            dgvClass2.Visible = true;
            lblClassThreePlayers.Visible = false;
            dgvClass3.Visible = false;
            

        }

        public void ShowElementsForThreeClasses()
        {
            lblClass1Min.Visible = true;
            lblClass1Max.Visible = true;
            lblClass1.Visible = true;
            lblClass2Min.Visible = true;
            lblClass2Max.Visible = true;
            lblClass2.Visible = true;
            lblClass3Min.Visible = true;
            lblClass3Max.Visible = true;
            lblClass3.Visible = true;
            txtClassOneMin.Visible = true;
            cbxClassOneMax.Visible = true;
            txtClassTwoMin.Visible = true;
            cbxClassTwoMax.Visible = true;
            txtClassThreeMin.Visible = true;
            cbxClassThreeMax.Visible = true;
            lblClassOnePlayers.Visible = true;
            lblClassOnePlayers.Text = "Class 1 Players";
            lblClassTwoPlayers.Visible = true;
            dgvClass2.Visible = true;
            lblClassThreePlayers.Visible = true;
            dgvClass3.Visible = true;
        }

        private void cbxClassOneMax_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int classOneMax = 0;
            //int classTwoMin = 0;
            txtClassTwoMin.Text = cbxClassOneMax.SelectedIndex+1.ToString();
            //classTwoMin = classOneMax + 1;
            //txtClassTwoMin.Text = classTwoMin.ToString();
        }

        

        

        private void cbxClassTwoMax_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClassThreeMin.SelectedText = cbxClassTwoMax.SelectedText + 1;
        }
    }
}
