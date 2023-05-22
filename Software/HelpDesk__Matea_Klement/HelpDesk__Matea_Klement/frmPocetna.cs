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

        private void panelPocetna(object sender, PaintEventArgs e) {

        }


        private void button1_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            FrmProfil frmProfil = new FrmProfil();
            Hide();
            frmProfil.ShowDialog();
            Close();
        }

        private void FrmPocetna_Load(object sender, EventArgs e) {

        }
    }
}
