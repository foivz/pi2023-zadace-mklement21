namespace HelpDesk__Matea_Klement {
    partial class FrmPrijava {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijava));
            this.panelPrijava = new System.Windows.Forms.Panel();
            this.lblPrijavaKorisnika = new System.Windows.Forms.Label();
            this.panelPrijavaKorisnika = new System.Windows.Forms.Panel();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.panelPrijavaKorisnika.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrijava
            // 
            this.panelPrijava.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelPrijava.Location = new System.Drawing.Point(0, 16);
            this.panelPrijava.Name = "panelPrijava";
            this.panelPrijava.Size = new System.Drawing.Size(522, 41);
            this.panelPrijava.TabIndex = 2;
            // 
            // lblPrijavaKorisnika
            // 
            this.lblPrijavaKorisnika.AutoSize = true;
            this.lblPrijavaKorisnika.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPrijavaKorisnika.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijavaKorisnika.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrijavaKorisnika.Location = new System.Drawing.Point(170, 24);
            this.lblPrijavaKorisnika.Name = "lblPrijavaKorisnika";
            this.lblPrijavaKorisnika.Size = new System.Drawing.Size(179, 27);
            this.lblPrijavaKorisnika.TabIndex = 3;
            this.lblPrijavaKorisnika.Text = "Prijava korisnika";
            // 
            // panelPrijavaKorisnika
            // 
            this.panelPrijavaKorisnika.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPrijavaKorisnika.Controls.Add(this.txtLozinka);
            this.panelPrijavaKorisnika.Controls.Add(this.txtKorisnickoIme);
            this.panelPrijavaKorisnika.Controls.Add(this.lblLozinka);
            this.panelPrijavaKorisnika.Controls.Add(this.lblKorisnickoIme);
            this.panelPrijavaKorisnika.Location = new System.Drawing.Point(115, 80);
            this.panelPrijavaKorisnika.Name = "panelPrijavaKorisnika";
            this.panelPrijavaKorisnika.Size = new System.Drawing.Size(288, 167);
            this.panelPrijavaKorisnika.TabIndex = 4;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(59, 125);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(174, 22);
            this.txtLozinka.TabIndex = 3;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(59, 43);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(174, 22);
            this.txtKorisnickoIme.TabIndex = 2;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(117, 94);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(60, 19);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka";
            this.lblLozinka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(92, 15);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(108, 19);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.Location = new System.Drawing.Point(226, 262);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 300);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.panelPrijavaKorisnika);
            this.Controls.Add(this.lblPrijavaKorisnika);
            this.Controls.Add(this.panelPrijava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.panelPrijavaKorisnika.ResumeLayout(false);
            this.panelPrijavaKorisnika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrijava;
        private System.Windows.Forms.Label lblPrijavaKorisnika;
        private System.Windows.Forms.Panel panelPrijavaKorisnika;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Button btnPrijava;
    }
}