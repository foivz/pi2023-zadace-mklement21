namespace HelpDesk__Matea_Klement
{
    partial class FrmZahtjevi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelZahtjevi = new System.Windows.Forms.Panel();
            this.btnZahtjeviProfil = new System.Windows.Forms.Button();
            this.btnZahtjeviZahtjevi = new System.Windows.Forms.Button();
            this.lblZahtjevi = new System.Windows.Forms.Label();
            this.panelZahtjevi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelZahtjevi
            // 
            this.panelZahtjevi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelZahtjevi.Controls.Add(this.btnZahtjeviProfil);
            this.panelZahtjevi.Controls.Add(this.btnZahtjeviZahtjevi);
            this.panelZahtjevi.Location = new System.Drawing.Point(0, 26);
            this.panelZahtjevi.Name = "panelZahtjevi";
            this.panelZahtjevi.Size = new System.Drawing.Size(799, 41);
            this.panelZahtjevi.TabIndex = 4;
            this.panelZahtjevi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZahtjevi_Paint);
            // 
            // btnZahtjeviProfil
            // 
            this.btnZahtjeviProfil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZahtjeviProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZahtjeviProfil.Location = new System.Drawing.Point(507, 3);
            this.btnZahtjeviProfil.Name = "btnZahtjeviProfil";
            this.btnZahtjeviProfil.Size = new System.Drawing.Size(161, 35);
            this.btnZahtjeviProfil.TabIndex = 4;
            this.btnZahtjeviProfil.Text = "Profil";
            this.btnZahtjeviProfil.UseVisualStyleBackColor = false;
            this.btnZahtjeviProfil.Click += new System.EventHandler(this.btnZahtjeviProfil_Click);
            // 
            // btnZahtjeviZahtjevi
            // 
            this.btnZahtjeviZahtjevi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZahtjeviZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZahtjeviZahtjevi.Location = new System.Drawing.Point(149, 3);
            this.btnZahtjeviZahtjevi.Name = "btnZahtjeviZahtjevi";
            this.btnZahtjeviZahtjevi.Size = new System.Drawing.Size(161, 35);
            this.btnZahtjeviZahtjevi.TabIndex = 3;
            this.btnZahtjeviZahtjevi.Text = "Zahtjevi";
            this.btnZahtjeviZahtjevi.UseVisualStyleBackColor = false;
            this.btnZahtjeviZahtjevi.Click += new System.EventHandler(this.btnZahtjeviZahtjevi_Click);
            // 
            // lblZahtjevi
            // 
            this.lblZahtjevi.AutoSize = true;
            this.lblZahtjevi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZahtjevi.Location = new System.Drawing.Point(22, 89);
            this.lblZahtjevi.Name = "lblZahtjevi";
            this.lblZahtjevi.Size = new System.Drawing.Size(94, 27);
            this.lblZahtjevi.TabIndex = 5;
            this.lblZahtjevi.Text = "Zahtjevi";
            this.lblZahtjevi.Click += new System.EventHandler(this.lblPodatciProfila_Click);
            // 
            // FrmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZahtjevi);
            this.Controls.Add(this.panelZahtjevi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZahtjevi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahtjevi";
            this.panelZahtjevi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelZahtjevi;
        private System.Windows.Forms.Button btnZahtjeviProfil;
        private System.Windows.Forms.Button btnZahtjeviZahtjevi;
        private System.Windows.Forms.Label lblZahtjevi;
    }
}