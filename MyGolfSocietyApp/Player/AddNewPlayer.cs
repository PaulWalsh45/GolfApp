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
    public partial class AddNewPlayer : Form
    {
        public AddNewPlayer()
        {
            InitializeComponent();
        }

        private void btnAddPlayerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog getPicture = new OpenFileDialog();
            getPicture.Filter="Image Files(*.jpg;*jpeg;*.gif;*.bmp)| *.jpg; *jpeg; *.gif; *.bmp";
            if (getPicture.ShowDialog()==DialogResult.OK)
            {
                picBoxPlayer.Image = new Bitmap(getPicture.FileName);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
