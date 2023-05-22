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
            this.btnProfilProfil = new System.Windows.Forms.Button();
            this.btnProfilZahtjevi = new System.Windows.Forms.Button();
            this.lblPodatciProfila = new System.Windows.Forms.Label();
            this.lblProfilUsername = new System.Windows.Forms.Label();
            this.lblProfilEmail = new System.Windows.Forms.Label();
            this.lblProfilBroj = new System.Windows.Forms.Label();
            this.lblProfilTrenutnaZaporka = new System.Windows.Forms.Label();
            this.lblProfilNovaZaporka = new System.Windows.Forms.Label();
            this.panelProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfil
            // 
            this.panelProfil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelProfil.Controls.Add(this.btnProfilProfil);
            this.panelProfil.Controls.Add(this.btnProfilZahtjevi);
            this.panelProfil.Location = new System.Drawing.Point(0, 26);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(799, 41);
            this.panelProfil.TabIndex = 3;
            this.panelProfil.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProfil_Paint);
            // 
            // btnProfilProfil
            // 
            this.btnProfilProfil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProfilProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfilProfil.Location = new System.Drawing.Point(507, 3);
            this.btnProfilProfil.Name = "btnProfilProfil";
            this.btnProfilProfil.Size = new System.Drawing.Size(161, 35);
            this.btnProfilProfil.TabIndex = 4;
            this.btnProfilProfil.Text = "Profil";
            this.btnProfilProfil.UseVisualStyleBackColor = false;
            this.btnProfilProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnProfilZahtjevi
            // 
            this.btnProfilZahtjevi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProfilZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfilZahtjevi.Location = new System.Drawing.Point(149, 3);
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
            this.lblPodatciProfila.Location = new System.Drawing.Point(22, 89);
            this.lblPodatciProfila.Name = "lblPodatciProfila";
            this.lblPodatciProfila.Size = new System.Drawing.Size(159, 27);
            this.lblPodatciProfila.TabIndex = 4;
            this.lblPodatciProfila.Text = "Podatci profila";
            this.lblPodatciProfila.Click += new System.EventHandler(this.txtPodatciProfila_Click);
            // 
            // lblProfilUsername
            // 
            this.lblProfilUsername.AutoSize = true;
            this.lblProfilUsername.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilUsername.Location = new System.Drawing.Point(25, 149);
            this.lblProfilUsername.Name = "lblProfilUsername";
            this.lblProfilUsername.Size = new System.Drawing.Size(108, 19);
            this.lblProfilUsername.TabIndex = 5;
            this.lblProfilUsername.Text = "Korisničko ime";
            this.lblProfilUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfilEmail
            // 
            this.lblProfilEmail.AutoSize = true;
            this.lblProfilEmail.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilEmail.Location = new System.Drawing.Point(25, 189);
            this.lblProfilEmail.Name = "lblProfilEmail";
            this.lblProfilEmail.Size = new System.Drawing.Size(94, 19);
            this.lblProfilEmail.TabIndex = 6;
            this.lblProfilEmail.Text = "Email adresa";
            this.lblProfilEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfilBroj
            // 
            this.lblProfilBroj.AutoSize = true;
            this.lblProfilBroj.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilBroj.Location = new System.Drawing.Point(25, 229);
            this.lblProfilBroj.Name = "lblProfilBroj";
            this.lblProfilBroj.Size = new System.Drawing.Size(109, 19);
            this.lblProfilBroj.TabIndex = 7;
            this.lblProfilBroj.Text = "Telefonski broj";
            this.lblProfilBroj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfilTrenutnaZaporka
            // 
            this.lblProfilTrenutnaZaporka.AutoSize = true;
            this.lblProfilTrenutnaZaporka.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilTrenutnaZaporka.Location = new System.Drawing.Point(25, 309);
            this.lblProfilTrenutnaZaporka.Name = "lblProfilTrenutnaZaporka";
            this.lblProfilTrenutnaZaporka.Size = new System.Drawing.Size(127, 19);
            this.lblProfilTrenutnaZaporka.TabIndex = 8;
            this.lblProfilTrenutnaZaporka.Text = "Trenutna zaporka";
            this.lblProfilTrenutnaZaporka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfilNovaZaporka
            // 
            this.lblProfilNovaZaporka.AutoSize = true;
            this.lblProfilNovaZaporka.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProfilNovaZaporka.Location = new System.Drawing.Point(25, 357);
            this.lblProfilNovaZaporka.Name = "lblProfilNovaZaporka";
            this.lblProfilNovaZaporka.Size = new System.Drawing.Size(104, 19);
            this.lblProfilNovaZaporka.TabIndex = 9;
            this.lblProfilNovaZaporka.Text = "Nova zaporka";
            this.lblProfilNovaZaporka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProfilNovaZaporka);
            this.Controls.Add(this.lblProfilTrenutnaZaporka);
            this.Controls.Add(this.lblProfilBroj);
            this.Controls.Add(this.lblProfilEmail);
            this.Controls.Add(this.lblProfilUsername);
            this.Controls.Add(this.lblPodatciProfila);
            this.Controls.Add(this.panelProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.panelProfil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Button btnProfilProfil;
        private System.Windows.Forms.Button btnProfilZahtjevi;
        private System.Windows.Forms.Label lblPodatciProfila;
        private System.Windows.Forms.Label lblProfilUsername;
        private System.Windows.Forms.Label lblProfilEmail;
        private System.Windows.Forms.Label lblProfilBroj;
        private System.Windows.Forms.Label lblProfilTrenutnaZaporka;
        private System.Windows.Forms.Label lblProfilNovaZaporka;
    }
}