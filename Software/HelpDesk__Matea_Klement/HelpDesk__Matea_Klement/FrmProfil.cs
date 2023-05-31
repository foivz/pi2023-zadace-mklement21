using DBLayer;
using HelpDesk__Matea_Klement.Models;
using HelpDesk__Matea_Klement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk__Matea_Klement {
    //klasa FrmProfil
    public partial class FrmProfil : Form {
        public FrmProfil() {
            InitializeComponent();
        }

        /// <summary>
        /// metoda za prikaz forme Profil, aktivacija metode odabirom gumba "Profil"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfilProfil_Click(object sender, EventArgs e) {
            FrmProfil frmProfilProfil = new FrmProfil();
            Hide();
            frmProfilProfil.ShowDialog();
            Close();
        }
        /// <summary>
        /// metoda za prikaz forme Zahtjevi, aktivacija metode odabirom gumba "Zahtjevi"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfilZahtjevi_Click(object sender, EventArgs e) {
            FrmZahtjevi frmProfilZahtjevi = new FrmZahtjevi();
            Hide();
            frmProfilZahtjevi.ShowDialog();
            Close();
        }
        /// <summary>
        /// metoda za prikaz forme Početna, aktivacija metode odabirom gumba "Pocetna"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfilPocetna_Click(object sender, EventArgs e) {
            FrmPocetna frmProfilPocetna = new FrmPocetna();
            Hide();
            frmProfilPocetna.ShowDialog();
            Close();
        }
        /// <summary>
        /// metoda za očitavanje podataka profila prilikom dolaska na formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProfil_Load(object sender, EventArgs e) {
            var korisnik = FrmPrijava.LogiraniKorisnik;
            var logiraniKorisnik = KorisnikRepository.GetKorisnik(korisnik.IdKorisnik);

            txtImePrezime.Text = logiraniKorisnik.ToString();
            txtBroj.Text = logiraniKorisnik.BrojMobitela;
            txtTrenutnaZaporka.Text = logiraniKorisnik.Lozinka;
            txtKorisnickoIme.Text = logiraniKorisnik.KorisnickoIme;
        }
        /// <summary>
        /// metoda za odustajanje od promjena, aktivacija metode odabirom gumba "Odustani"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e) {
            FrmProfil frmProfil = new FrmProfil();
            this.Visible = false;
            frmProfil.ShowDialog();
            this.Close();
            Close();
        }
        /// <summary>
        /// metoda za spremanje promjena na profilu korisnika (ažuriranje), aktivacija metode odabirom gumba "Spremi", moguća promjena podataka korisničko ime i broj mobitela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e) {
            Korisnik azuriranjeKorisnika = KorisnikRepository.GetKorisnik(4);
            azuriranjeKorisnika.KorisnickoIme = txtKorisnickoIme.Text;
            azuriranjeKorisnika.BrojMobitela = txtBroj.Text;

            KorisnikRepository korisnik = new KorisnikRepository();
            korisnik.AzurirajKorisnika(azuriranjeKorisnika);
            FrmProfil frmProfil = new FrmProfil();
            this.Visible = false;
            frmProfil.ShowDialog();
            this.Close();
            Close();
        }
    }
}
