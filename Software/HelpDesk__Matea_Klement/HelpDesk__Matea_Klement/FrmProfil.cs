﻿using DBLayer;
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
    public partial class FrmProfil : Form {
        public FrmProfil() {
            InitializeComponent();
        }

        private void btnProfilProfil_Click(object sender, EventArgs e) {
            FrmProfil frmProfilProfil = new FrmProfil();
            Hide();
            frmProfilProfil.ShowDialog();
            Close();
        }

        private void btnProfilZahtjevi_Click(object sender, EventArgs e) {
            FrmZahtjevi frmProfilZahtjevi = new FrmZahtjevi();
            Hide();
            frmProfilZahtjevi.ShowDialog();
            Close();
        }

        private void btnProfilPocetna_Click(object sender, EventArgs e) {
            FrmPocetna frmProfilPocetna = new FrmPocetna();
            Hide();
            frmProfilPocetna.ShowDialog();
            Close();
        }

        private void FrmProfil_Load(object sender, EventArgs e) {
            var activities = KorisnikRepository.GetKorisnik(4);

            txtImePrezime.Text = activities.ToString();
            txtBroj.Text = activities.BrojMobitela;
            txtTrenutnaZaporka.Text = activities.Lozinka;
            txtKorisnickoIme.Text = activities.KorisnickoIme;
        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            FrmProfil form = new FrmProfil();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
            Close();
        }
    }
}
