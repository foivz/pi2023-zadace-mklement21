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
    public partial class FrmKreirajZahtjev : Form {
        private Zahtjev zahtjev;
        List<Zahtjev> zahtjevi { get; set; }
        Zahtjev NoviZahtjev { get; set; }


        public FrmKreirajZahtjev(Models.Zahtjev selectedZahtjev) {
            InitializeComponent();
            zahtjev = selectedZahtjev;
        }

        private void btnKreiranjeOdustani_Click(object sender, EventArgs e) {
            FrmZahtjevi form = new FrmZahtjevi();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }

        private void btnKreiranjeSpremi_Click(object sender, EventArgs e) {
            Zahtjev noviZahtjev = new Zahtjev {
                ZahtjevNaslov = txtNoviNaslov.Text,
                IdZahtjev = int.Parse(txtNoviID.Text),
                ZahtjevDatum = dtpNoviDatum.Value,
                Status = txtNoviOpis.Text,
            };

            ZahtjevRepository zahtjev = new ZahtjevRepository();
            ZahtjevRepository.KreirajZahtjev(noviZahtjev);

            FrmZahtjevi form = new FrmZahtjevi();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }
    }
}

        
    

        /*
        private void btnKreiranjeSpremi_Click(object sender, EventArgs e) {
            Zahtjev noviZahtjev = new Zahtjev {
                ZahtjevNaslov = int.Parse(txtNoviNaslov.Text);

            }


            /*
            NoviZahtjev.ZahtjevNaslov = txtNoviNaslov.Text;
            NoviZahtjev.ZahtjevDatum = dtpNoviDatum.Value;
            ZahtjevRepository.KreirajZahtjev(NoviZahtjev);
            Hide();
            Close();

           // FrmKreirajZahtjev frmKreirajZahtjev = new DB().SetConfiguration();
            //frmKreirajZahtjev.ShowDialog();
            */
    

        /*private void btnOdustani_Click(object sender, EventArgs e) {
            FrmZahtjevi form = new FrmZahtjevi();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }*/
