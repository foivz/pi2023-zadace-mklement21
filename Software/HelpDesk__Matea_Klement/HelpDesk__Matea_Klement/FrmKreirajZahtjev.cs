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
        //metoda za odustajanje od podnošenja novog zahtjeva, aktivira se odabirom gumba "Odustani"
        private void btnKreiranjeOdustani_Click(object sender, EventArgs e) {
            FrmZahtjevi frmZahtjevi = new FrmZahtjevi();
            this.Visible = false;
            frmZahtjevi.ShowDialog();
            this.Close();
        }
        //metoda za kreiranje novog zahtjeva, aktivira se odabirom gumba "Spremi"
        private void btnKreiranjeSpremi_Click(object sender, EventArgs e) {
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