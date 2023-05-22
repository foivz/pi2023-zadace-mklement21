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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZahtjevi = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPozdrav = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.btnZahtjevi);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 41);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnZahtjevi
            // 
            this.btnZahtjevi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZahtjevi.Location = new System.Drawing.Point(149, 3);
            this.btnZahtjevi.Name = "btnZahtjevi";
            this.btnZahtjevi.Size = new System.Drawing.Size(161, 35);
            this.btnZahtjevi.TabIndex = 3;
            this.btnZahtjevi.Text = "Zahtjevi";
            this.btnZahtjevi.UseVisualStyleBackColor = false;
            this.btnZahtjevi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfil.Location = new System.Drawing.Point(507, 3);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(161, 35);
            this.btnProfil.TabIndex = 4;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.button1_Click_1);
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
            this.panel3.Controls.Add(this.lblBroj);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblAdresa);
            this.panel3.Controls.Add(this.lblKontakt);
            this.panel3.Location = new System.Drawing.Point(200, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 97);
            this.panel3.TabIndex = 4;
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
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(317, 10);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(84, 19);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa : FOI";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(262, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(139, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "helpdesk@gmail.com";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBroj.Location = new System.Drawing.Point(304, 69);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(97, 19);
            this.lblBroj.TabIndex = 3;
            this.lblBroj.Text = "+385*********";
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPocetna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZahtjevi;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPozdrav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBroj;
    }
}