using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk__Matea_Klement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if ( username == "" && password == "") {
                MessageBox.Show("Niste ispunili sve podatke", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if ( username == "") {
                MessageBox.Show("Niste unijeli korisničko ime", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if ( password == " ") {
                MessageBox.Show("Niste unijeli lozinku", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else {
                if ( username == "student" && password == "student") {
                    FrmPocetna frmPocetna = new FrmPocetna();

                    frmPocetna.ShowDialog();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
