using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;

namespace MyGolfSocietyApp
{
    public partial class AddNewCourse : Form
    {
        public AddNewCourse()
        {
            InitializeComponent();
        }

        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            int[] pars = GetPars();
            int[] index = GetIndex();

            course.Name = txtCourseName.Text;
            course.Address = txtCourseAddress.Text;
            course.Phone = txtCoursePhone.Text;
            course.Email = txtCourseEmail.Text;
            course.HolePars = pars;
            course.HoleIndexs = index;


        }

        private int[] GetIndex()
        {
            return new int[18] { int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text),
                int.Parse(txtIndex1.Text), int.Parse(txtIndex1.Text) };
        }

        private int[] GetPars()
        {
            return new int[18] { int.Parse(txtPar1.Text), int.Parse(txtPar2.Text),
                int.Parse(txtPar3.Text), int.Parse(txtPar4.Text),
                int.Parse(txtPar5.Text), int.Parse(txtPar6.Text),
                int.Parse(txtPar7.Text), int.Parse(txtPar8.Text),
                int.Parse(txtPar9.Text), int.Parse(txtPar10.Text),
                int.Parse(txtPar11.Text), int.Parse(txtPar12.Text),
                int.Parse(txtPar13.Text), int.Parse(txtPar14.Text),
                int.Parse(txtPar15.Text), int.Parse(txtPar16.Text),
                int.Parse(txtPar17.Text), int.Parse(txtPar18.Text) };
        }
    }
}
