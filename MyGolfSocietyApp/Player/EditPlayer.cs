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
    public partial class EditPlayer : Form
    {
        public EditPlayer()
        {
            InitializeComponent();
        }

        private void btnChangePlayerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog changePicture = new OpenFileDialog();
            changePicture.Filter = "Image Files(*.jpg;*jpeg;*.gif;*.bmp)| *.jpg; *jpeg; *.gif; *.bmp";
            if (changePicture.ShowDialog() == DialogResult.OK)
            {
                picBoxPlayer.Image = new Bitmap(changePicture.FileName);
            }
        }
    }
}
