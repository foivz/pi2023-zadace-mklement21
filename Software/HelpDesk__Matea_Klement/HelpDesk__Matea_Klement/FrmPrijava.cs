using HelpDesk__Matea_Klement.Models;
using HelpDesk__Matea_Klement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk__Matea_Klement {
    //klasa FrmPrijava
    public partial class FrmPrijava : Form {
        public static Korisnik LogiraniKorisnik { get; set; }

        public FrmPrijava() {
            InitializeComponent();
        }

        //metoda za provjeru korisničkih podataka te prikaz Početnog zaslona ukoliko su korisnički podatci ispravni
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
                if (korisnickoIme == "majakos" && lozinka == "123456") {
                    FrmPocetna frmPocetna = new FrmPocetna();

                    frmPocetna.ShowDialog();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
