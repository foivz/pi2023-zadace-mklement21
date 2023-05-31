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

namespace HelpDesk__Matea_Klement {
    //klasa FrmKreirajZahtjev
    public partial class FrmKreirajZahtjev : Form {
        private Zahtjev zahtjev;

        public FrmKreirajZahtjev(Models.Zahtjev selectedZahtjev) {
            InitializeComponent();
            zahtjev = selectedZahtjev;
        }
        /// <summary>
        /// metoda za odustajanje od podnošenja novog zahtjeva, aktivira se odabirom gumba "Odustani"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKreiranjeOdustani_Click(object sender, EventArgs e) {
            FrmZahtjevi frmZahtjevi = new FrmZahtjevi();
            this.Visible = false;
            frmZahtjevi.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// metoda za kreiranje novog zahtjeva, aktivira se odabirom gumba "Spremi"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKreiranjeSpremi_Click(object sender, EventArgs e) {
            MessageBox.Show("Novi zahtjev kreiran!", "Kreiran zahtjev", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Zahtjev noviZahtjev = new Zahtjev {
                ZahtjevNaslov = txtNoviNaslov.Text,
                ZahtjevDatum = dtpNoviDatum.Value,
                ZahtjevOpis = txtNoviOpis.Text,
            };

            ZahtjevRepository zahtjev = new ZahtjevRepository();
            ZahtjevRepository.KreirajZahtjev(noviZahtjev);

            FrmZahtjevi frmZahtjevi = new FrmZahtjevi();
            this.Visible = false;
            frmZahtjevi.ShowDialog();
            this.Close();
        }
    }
}