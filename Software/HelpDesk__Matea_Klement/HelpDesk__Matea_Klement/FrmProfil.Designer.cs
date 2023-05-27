namespace HelpDesk__Matea_Klement {
    partial class FrmProfil {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelProfil = new System.Windows.Forms.Panel();
            this.btnProfilPocetna = new System.Windows.Forms.Button();
            this.btnProfilProfil = new System.Windows.Forms.Button();
            this.btnProfilZahtjevi = new System.Windows.Forms.Button();
            this.lblPodatciProfila = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblProfilBroj = new System.Windows.Forms.Label();
            this.lblProfilTrenutnaZaporka = new System.Windows.Forms.Label();
            this.lblProfilNovaZaporka = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtTrenutnaZaporka = new System.Windows.Forms.TextBox();
            this.txtNovaZaporka = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.panelProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfil
            // 
            this.panelProfil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelProfil.Controls.Add(this.btnProfilPocetna);
            this.panelProfil.Controls.Add(this.btnProfilProfil);
            this.panelProfil.Controls.Add(this.btnProfilZahtjevi);
            this.panelProfil.Location = new System.Drawing.Point(0, 16);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(799, 41);
            this.panelProfil.TabIndex = 4;
            // 
            // btnProfilPocetna
            // 
            this.btnProfilPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfilPocetna.Location = new System.Drawing.Point(63, 3);
            this.btnProfilPocetna.Name = "btnProfilPocetna";
            this.btnProfilPocetna.Size = new System.Drawing.Size(161, 35);
            this.btnProfilPocetna.TabIndex = 11;
            this.btnProfilPocetna.Text = "Početna";
            this.btnProfilPocetna.UseVisualStyleBackColor = true;
            this.btnProfilPocetna.Click += new System.EventHandler(this.btnProfilPocetna_Click);
            // 
            // btnProfilProfil
            // 
            this.btnProfilProfil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProfilProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfilProfil.Location = new System.Drawing.Point(567, 3);
            this.btnProfilProfil.Name = "btnProfilProfil";
            this.btnProfilProfil.Size = new System.Drawing.Size(161, 35);
            this.btnProfilProfil.TabIndex = 4;
            this.btnProfilProfil.Text = "Profil";
            this.btnProfilProfil.UseVisualStyleBackColor = false;
            this.btnProfilProfil.Click += new System.EventHandler(this.btnProfilProfil_Click);
            // 
            // btnProfilZahtjevi
            // 
            this.btnProfilZahtjevi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProfilZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfilZahtjevi.Location = new System.Drawing.Point(315, 3);
            this.btnProfilZahtjevi.Name = "btnProfilZahtjevi";
            this.btnProfilZahtjevi.Size = new System.Drawing.Size(161, 35);
            this.btnProfilZahtjevi.TabIndex = 3;
            this.btnProfilZahtjevi.Text = "Zahtjevi";
            this.btnProfilZahtjevi.UseVisualStyleBackColor = false;
            this.btnProfilZahtjevi.Click += new System.EventHandler(this.btnProfilZahtjevi_Click);
            // 
            // lblPodatciProfila
            // 
            this.lblPodatciProfila.AutoSize = true;
            this.lblPodatciProfila.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodatciProfila.Location = new System.Drawing.Point(33, 94);
            this.lblPodatciProfila.Name = "lblPodatciProfila";
            this.lblPodatciProfila.Size = new System.Drawing.Size(159, 27);
            this.lblPodatciProfila.TabIndex = 5;
            this.lblPodatciProfila.Text = "Podatci profila";
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImePrezime.Location = new System.Drawing.Point(35, 156);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(101, 19);
            this.lblImePrezime.TabIndex = 6;
            this.lblImePrezime.Text = "Ime i prezime";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfilBroj
            // 
            this.lblProfilBroj.AutoSize = true;
            this.lblProfilBroj.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilBroj.Location = new System.Drawing.Point(35, 255);
            this.lblProfilBroj.Name = "lblProfilBroj";
            this.lblProfilBroj.Size = new System.Drawing.Size(109, 19);
            this.lblProfilBroj.TabIndex = 8;
            this.lblProfilBroj.Text = "Telefonski broj";
            this.lblProfilBroj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfilTrenutnaZaporka
            // 
            this.lblProfilTrenutnaZaporka.AutoSize = true;
            this.lblProfilTrenutnaZaporka.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilTrenutnaZaporka.Location = new System.Drawing.Point(34, 331);
            this.lblProfilTrenutnaZaporka.Name = "lblProfilTrenutnaZaporka";
            this.lblProfilTrenutnaZaporka.Size = new System.Drawing.Size(127, 19);
            this.lblProfilTrenutnaZaporka.TabIndex = 9;
            this.lblProfilTrenutnaZaporka.Text = "Trenutna zaporka";
            this.lblProfilTrenutnaZaporka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfilNovaZaporka
            // 
            this.lblProfilNovaZaporka.AutoSize = true;
            this.lblProfilNovaZaporka.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilNovaZaporka.Location = new System.Drawing.Point(35, 382);
            this.lblProfilNovaZaporka.Name = "lblProfilNovaZaporka";
            this.lblProfilNovaZaporka.Size = new System.Drawing.Size(104, 19);
            this.lblProfilNovaZaporka.TabIndex = 10;
            this.lblProfilNovaZaporka.Text = "Nova zaporka";
            this.lblProfilNovaZaporka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(185, 153);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(168, 22);
            this.txtImePrezime.TabIndex = 11;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(185, 255);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(168, 22);
            this.txtBroj.TabIndex = 13;
            // 
            // txtTrenutnaZaporka
            // 
            this.txtTrenutnaZaporka.Location = new System.Drawing.Point(185, 330);
            this.txtTrenutnaZaporka.Name = "txtTrenutnaZaporka";
            this.txtTrenutnaZaporka.PasswordChar = '*';
            this.txtTrenutnaZaporka.Size = new System.Drawing.Size(168, 22);
            this.txtTrenutnaZaporka.TabIndex = 14;
            // 
            // txtNovaZaporka
            // 
            this.txtNovaZaporka.Location = new System.Drawing.Point(185, 379);
            this.txtNovaZaporka.Name = "txtNovaZaporka";
            this.txtNovaZaporka.Size = new System.Drawing.Size(168, 22);
            this.txtNovaZaporka.TabIndex = 15;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(34, 204);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(108, 19);
            this.lblKorisnickoIme.TabIndex = 16;
            this.lblKorisnickoIme.Text = "Korisnicko ime";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(185, 201);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(168, 22);
            this.txtKorisnickoIme.TabIndex = 17;
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtNovaZaporka);
            this.Controls.Add(this.txtTrenutnaZaporka);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.lblProfilNovaZaporka);
            this.Controls.Add(this.lblProfilTrenutnaZaporka);
            this.Controls.Add(this.lblProfilBroj);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.lblPodatciProfila);
            this.Controls.Add(this.panelProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil korisnika";
            this.Load += new System.EventHandler(this.FrmProfil_Load);
            this.panelProfil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Button btnProfilProfil;
        private System.Windows.Forms.Button btnProfilZahtjevi;
        private System.Windows.Forms.Label lblPodatciProfila;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblProfilBroj;
        private System.Windows.Forms.Label lblProfilTrenutnaZaporka;
        private System.Windows.Forms.Label lblProfilNovaZaporka;
        private System.Windows.Forms.Button btnProfilPocetna;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtTrenutnaZaporka;
        private System.Windows.Forms.TextBox txtNovaZaporka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
    }
}