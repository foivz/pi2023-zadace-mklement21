using HelpDesk__Matea_Klement.Models;
using HelpDesk__Matea_Klement.Repositories;
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
    public partial class FrmZahtjevi: Form
    {
        public FrmZahtjevi()
        {
            InitializeComponent();
        }

        private void lblPodatciProfila_Click(object sender, EventArgs e) {

        }

        private void btnZahtjeviProfil_Click(object sender, EventArgs e) {
            FrmProfil frmZahtjeviProfil = new FrmProfil();
            Hide();
            frmZahtjeviProfil.ShowDialog();
            Close();
        }

        private void btnZahtjeviZahtjevi_Click(object sender, EventArgs e) {
            FrmZahtjevi frmZahtjeviZahtjevi = new FrmZahtjevi();
            Hide();
            frmZahtjeviZahtjevi.ShowDialog();
            Close();
        }

        private void panelZahtjevi_Paint(object sender, PaintEventArgs e) {

        }

        private void btnZahtjeviPocetna_Click(object sender, EventArgs e) {
            FrmPocetna frmZahtjeviPocetna = new FrmPocetna();
            Hide();
            frmZahtjeviPocetna.ShowDialog();
            Close();
        }

        //dohvaćanje zahtjeva
        private void FrmZahtjevi_Load(object sender, EventArgs e) {
            ShowZahtjevi();
        } 

        private void ShowZahtjevi() {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;
            

            /*
            var zahtjevi = ZahtjevRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;

            dgvZahtjevi.Columns["IdZahtjev"].HeaderCell.Value = "Šifra";
            dgvZahtjevi.Columns["ZahtjevNaslov"].HeaderCell.Value = "Šifra";
            dgvZahtjevi.Columns["Status"].HeaderCell.Value = "Šifra";
            dgvZahtjevi.Columns["ZahtjevDatum"].HeaderCell.Value = "Šifra";


            /*
            dgvZahtjevi.Columns["IdZahtjev"].DisplayIndex = 0;
            dgvZahtjevi.Columns["ZahtjevNaslov"].DisplayIndex = 1;
            dgvZahtjevi.Columns["Status"].DisplayIndex = 2;
            dgvZahtjevi.Columns["ZahtjevDatum"].DisplayIndex = 3;
            */
        }
    }
}
