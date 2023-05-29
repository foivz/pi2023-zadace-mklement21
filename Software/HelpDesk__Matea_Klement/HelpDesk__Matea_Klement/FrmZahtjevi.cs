using DBLayer;
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

        //prikaz podnesenih zahtjeva
        private void ShowZahtjevi() {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;
            dgvZahtjevi.Columns["IdZahtjev"].DisplayIndex = 0;
            dgvZahtjevi.Columns["ZahtjevNaslov"].DisplayIndex = 1;
            dgvZahtjevi.Columns["Status"].DisplayIndex = 2;
            dgvZahtjevi.Columns["ZahtjevDatum"].DisplayIndex = 3;
            dgvZahtjevi.Columns["ZahtjevOpis"].DisplayIndex = 4;

            dgvZahtjevi.Columns["IdZahtjev"].HeaderCell.Value = "Br.";
            dgvZahtjevi.Columns["ZahtjevNaslov"].HeaderCell.Value = "Naslov";
            dgvZahtjevi.Columns["Status"].HeaderCell.Value = "Status";
            dgvZahtjevi.Columns["ZahtjevDatum"].HeaderCell.Value = "Datum";
            dgvZahtjevi.Columns["ZahtjevOpis"].HeaderCell.Value = "Opis zahtjeva";
            dgvZahtjevi.GridColor = Color.DeepSkyBlue;

            dgvZahtjevi.Columns["IdZahtjev"].Width = 30;
            dgvZahtjevi.Columns["ZahtjevNaslov"].Width = 130;
            dgvZahtjevi.Columns["ZahtjevDatum"].Width = 70;
            dgvZahtjevi.Columns["ZahtjevOpis"].Width = 200;
        }

        //odlazak na izradu zahtjeva
        private void btnKreirajZahtjev_Click(object sender, EventArgs e) {
            Zahtjev selectedZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            if (selectedZahtjev != null) {
                FrmKreirajZahtjev frmKreirajZahtjev = new FrmKreirajZahtjev(selectedZahtjev);
                frmKreirajZahtjev.ShowDialog();
            }
        }

        //brisanje zahtjeva
        private void btnObrisi_Click(object sender, EventArgs e) {
            Zahtjev selectedZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            if (selectedZahtjev != null) {
                ZahtjevRepository.ObrisiZahtjev(selectedZahtjev);
            }
            FrmZahtjevi frmZahtjevi = new FrmZahtjevi();
            this.Visible = false;
            frmZahtjevi.ShowDialog();
            this.Close();
        }

        //pretrazivanje zahtjeva 
        private void txtPretrazi_TextChanged_1(object sender, EventArgs e) {
            var pretrazivaniZahtjev = ZahtjevRepository.GetSearchedZahtjev(txtPretrazi.Text);
            dgvZahtjevi.DataSource = pretrazivaniZahtjev;

            dgvZahtjevi.Columns["IdZahtjev"].DisplayIndex = 0;
            dgvZahtjevi.Columns["ZahtjevNaslov"].DisplayIndex = 1;
            dgvZahtjevi.Columns["Status"].DisplayIndex = 2;
            dgvZahtjevi.Columns["ZahtjevDatum"].DisplayIndex = 3;
            dgvZahtjevi.Columns["ZahtjevOpis"].DisplayIndex = 4;
        }
    }
}
