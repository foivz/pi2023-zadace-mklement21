namespace HelpDesk__Matea_Klement {
    partial class FrmPocetna {
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
            System.Windows.Forms.Panel panelPocetna;
            this.btnPocetnaProfil = new System.Windows.Forms.Button();
            this.btnPocetnaZahtjevi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPozdrav = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKontaktBroj = new System.Windows.Forms.Label();
            this.lblKontaktEmail = new System.Windows.Forms.Label();
            this.lblKontaktAdresa = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            panelPocetna = new System.Windows.Forms.Panel();
            panelPocetna.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPocetna
            // 
            panelPocetna.BackColor = System.Drawing.SystemColors.ButtonShadow;
            panelPocetna.Controls.Add(this.btnPocetnaProfil);
            panelPocetna.Controls.Add(this.btnPocetnaZahtjevi);
            panelPocetna.Location = new System.Drawing.Point(0, 26);
            panelPocetna.Name = "panelPocetna";
            panelPocetna.Size = new System.Drawing.Size(799, 41);
            panelPocetna.TabIndex = 2;
            panelPocetna.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPocetna);
            // 
            // btnPocetnaProfil
            // 
            this.btnPocetnaProfil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPocetnaProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPocetnaProfil.Location = new System.Drawing.Point(507, 3);
            this.btnPocetnaProfil.Name = "btnPocetnaProfil";
            this.btnPocetnaProfil.Size = new System.Drawing.Size(161, 35);
            this.btnPocetnaProfil.TabIndex = 4;
            this.btnPocetnaProfil.Text = "Profil";
            this.btnPocetnaProfil.UseVisualStyleBackColor = false;
            this.btnPocetnaProfil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPocetnaZahtjevi
            // 
            this.btnPocetnaZahtjevi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPocetnaZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPocetnaZahtjevi.Location = new System.Drawing.Point(149, 3);
            this.btnPocetnaZahtjevi.Name = "btnPocetnaZahtjevi";
            this.btnPocetnaZahtjevi.Size = new System.Drawing.Size(161, 35);
            this.btnPocetnaZahtjevi.TabIndex = 3;
            this.btnPocetnaZahtjevi.Text = "Zahtjevi";
            this.btnPocetnaZahtjevi.UseVisualStyleBackColor = false;
            this.btnPocetnaZahtjevi.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblPozdrav);
            this.panel2.Location = new System.Drawing.Point(115, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 83);
            this.panel2.TabIndex = 3;
            // 
            // lblPozdrav
            // 
            this.lblPozdrav.AutoSize = true;
            this.lblPozdrav.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozdrav.Location = new System.Drawing.Point(40, 26);
            this.lblPozdrav.Name = "lblPozdrav";
            this.lblPozdrav.Size = new System.Drawing.Size(514, 32);
            this.lblPozdrav.TabIndex = 0;
            this.lblPozdrav.Text = "Dobrodošli u CIP HelpDesk sustav !";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.lblKontaktBroj);
            this.panel3.Controls.Add(this.lblKontaktEmail);
            this.panel3.Controls.Add(this.lblKontaktAdresa);
            this.panel3.Controls.Add(this.lblKontakt);
            this.panel3.Location = new System.Drawing.Point(200, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 97);
            this.panel3.TabIndex = 4;
            // 
            // lblKontaktBroj
            // 
            this.lblKontaktBroj.AutoSize = true;
            this.lblKontaktBroj.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontaktBroj.Location = new System.Drawing.Point(304, 69);
            this.lblKontaktBroj.Name = "lblKontaktBroj";
            this.lblKontaktBroj.Size = new System.Drawing.Size(97, 19);
            this.lblKontaktBroj.TabIndex = 3;
            this.lblKontaktBroj.Text = "+385*********";
            // 
            // lblKontaktEmail
            // 
            this.lblKontaktEmail.AutoSize = true;
            this.lblKontaktEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontaktEmail.Location = new System.Drawing.Point(262, 38);
            this.lblKontaktEmail.Name = "lblKontaktEmail";
            this.lblKontaktEmail.Size = new System.Drawing.Size(139, 19);
            this.lblKontaktEmail.TabIndex = 2;
            this.lblKontaktEmail.Text = "helpdesk@gmail.com";
            // 
            // lblKontaktAdresa
            // 
            this.lblKontaktAdresa.AutoSize = true;
            this.lblKontaktAdresa.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontaktAdresa.Location = new System.Drawing.Point(317, 10);
            this.lblKontaktAdresa.Name = "lblKontaktAdresa";
            this.lblKontaktAdresa.Size = new System.Drawing.Size(84, 19);
            this.lblKontaktAdresa.TabIndex = 1;
            this.lblKontaktAdresa.Text = "Adresa : FOI";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontakt.Location = new System.Drawing.Point(12, 34);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(169, 23);
            this.lblKontakt.TabIndex = 0;
            this.lblKontakt.Text = "Kontakt informacije";
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(panelPocetna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPocetna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            panelPocetna.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPocetnaZahtjevi;
        private System.Windows.Forms.Button btnPocetnaProfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPozdrav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblKontaktAdresa;
        private System.Windows.Forms.Label lblKontaktEmail;
        private System.Windows.Forms.Label lblKontaktBroj;
    }
}