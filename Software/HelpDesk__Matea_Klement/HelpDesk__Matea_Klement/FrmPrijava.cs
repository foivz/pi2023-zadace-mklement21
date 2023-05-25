using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk__Matea_Klement {
    public partial class FrmPrijava : Form {
        public FrmPrijava() {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e) {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            if (korisnickoIme == "" && lozinka == "") {
                MessageBox.Show("Niste ispunili sve podatke", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (korisnickoIme == "") {
                MessageBox.Show("Niste unijeli korisničko ime", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (lozinka == " ") {
                MessageBox.Show("Niste unijeli lozinku", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (korisnickoIme == "student" && lozinka == "1234" || korisnickoIme == "profesor" && lozinka == "1234") {
                    FrmPocetna frmPocetna = new FrmPocetna();

                    frmPocetna.ShowDialog();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
