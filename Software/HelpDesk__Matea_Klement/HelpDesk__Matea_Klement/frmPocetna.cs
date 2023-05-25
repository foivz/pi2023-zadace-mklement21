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
    public partial class FrmPocetna : Form {
        public FrmPocetna() {
            InitializeComponent();
        }

        private void btnPocetnaProfil_Click(object sender, EventArgs e) {
            FrmProfil frmPocetnaProfil = new FrmProfil();
            Hide();
            frmPocetnaProfil.ShowDialog();
            Close();
        }

        private void btnPocetnaZahtjevi_Click(object sender, EventArgs e) {
            FrmZahtjevi frmPocetnaZahtjevi = new FrmZahtjevi();
            Hide();
            frmPocetnaZahtjevi.ShowDialog();
            Close();
        }

        private void btnPocetnaPocetna_Click(object sender, EventArgs e) {
            FrmPocetna frmPocetnaPocetna = new FrmPocetna();
            Hide();
            frmPocetnaPocetna.ShowDialog();
            Close();
        }
    }
}
