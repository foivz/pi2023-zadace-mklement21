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
    //klasa FrmPocetna
    public partial class FrmPocetna : Form {
        public FrmPocetna() {
            InitializeComponent();
        }
        //metoda za prikaz forme Profil, aktivacija metode odabirom gumba "Profil"
        private void btnPocetnaProfil_Click(object sender, EventArgs e) {
            FrmProfil frmPocetnaProfil = new FrmProfil();
            Hide();
            frmPocetnaProfil.ShowDialog();
            Close();
        }
        //metoda za prikaz forme Zahtjevi, aktivacija metode odabirom gumba "Zahtjevi"
        private void btnPocetnaZahtjevi_Click(object sender, EventArgs e) {
            FrmZahtjevi frmPocetnaZahtjevi = new FrmZahtjevi();
            Hide();
            frmPocetnaZahtjevi.ShowDialog();
            Close();
        }
        //metoda za prikaz forme Početna, aktivacija metode odabirom gumba "Početna"
        private void btnPocetnaPocetna_Click(object sender, EventArgs e) {
            FrmPocetna frmPocetnaPocetna = new FrmPocetna();
            Hide();
            frmPocetnaPocetna.ShowDialog();
            Close();
        }
    }
}
