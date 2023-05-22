using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationManager.Models;
using EvaluationManager.Repositories;

namespace EvaluationManager
{
    public partial class FrmLogin : Form
    {
        public static Teacher LoggedTeacher { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoggedTeacher = TeacherRepository.GetTeacher(txtUsername.Text);
            
            if (txtUsername.Text == "" || txtPassword.Text == "" )
            {
                MessageBox.Show("Unesite vrijednosti u formu!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(LoggedTeacher != null && LoggedTeacher.Password == txtPassword.Text)
            {
                FrmStudents frmStudents = new FrmStudents();
                Hide();
                frmStudents.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Unijeli ste krive vrijednosti", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
