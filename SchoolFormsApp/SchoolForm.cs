using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary; 

namespace SchoolFormsApp
{
    public partial class SchoolForm : Form
    {
        public SchoolForm()
        {
            InitializeComponent();
        }

        private void baseButton_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = txtName.Text; 
            testSchool.Address = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.PhoneNumber = txtPhone.Text;
            testSchool.Province = txtProvince.Text;
            testSchool.PostalCode = txtPostalCode.Text;

            try
            {
                testSchool.TwitterAddress = txtTwitter.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

            MessageBox.Show(testSchool.ToString());

        }

        private void tstTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.computeGPA();
            MessageBox.Show("GPA: " + gp); 
        }

        private void tstStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.computeGPA();
            MessageBox.Show("GPA: " + gp); 
        }
    }
}
