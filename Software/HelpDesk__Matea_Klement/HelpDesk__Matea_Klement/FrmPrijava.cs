﻿using HelpDesk__Matea_Klement.Models;
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

        /// <summary>
        /// metoda za provjeru korisničkih podataka te prikaz Početnog zaslona ukoliko su korisnički podatci ispravni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijava_Click(object sender, EventArgs e) {
            if (txtKorisnickoIme.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtLozinka.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                LogiraniKorisnik = KorisnikRepository.GetKorisnik(txtKorisnickoIme.Text);
                if (LogiraniKorisnik != null && int.Parse(LogiraniKorisnik.Lozinka) == int.Parse(txtLozinka.Text)) {
                    FrmPocetna frmPocetna = new FrmPocetna();
                    this.Hide(); 
                    frmPocetna.ShowDialog();
                    this.Close();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
