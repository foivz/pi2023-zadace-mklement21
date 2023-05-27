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
            this.btnZahtjeviPocetna = new System.Windows.Forms.Button();
            this.btnZahtjeviProfil = new System.Windows.Forms.Button();
            this.btnZahtjeviZahtjevi = new System.Windows.Forms.Button();
            this.lblZahtjevi = new System.Windows.Forms.Label();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.panelZahtjevi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelZahtjevi
            // 
            this.panelZahtjevi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelZahtjevi.Controls.Add(this.btnZahtjeviPocetna);
            this.panelZahtjevi.Controls.Add(this.btnZahtjeviProfil);
            this.panelZahtjevi.Controls.Add(this.btnZahtjeviZahtjevi);
            this.panelZahtjevi.Location = new System.Drawing.Point(0, 16);
            this.panelZahtjevi.Name = "panelZahtjevi";
            this.panelZahtjevi.Size = new System.Drawing.Size(799, 41);
            this.panelZahtjevi.TabIndex = 4;
            this.panelZahtjevi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZahtjevi_Paint);
            // 
            // btnZahtjeviPocetna
            // 
            this.btnZahtjeviPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZahtjeviPocetna.Location = new System.Drawing.Point(63, 3);
            this.btnZahtjeviPocetna.Name = "btnZahtjeviPocetna";
            this.btnZahtjeviPocetna.Size = new System.Drawing.Size(161, 35);
            this.btnZahtjeviPocetna.TabIndex = 7;
            this.btnZahtjeviPocetna.Text = "Početna";
            this.btnZahtjeviPocetna.UseVisualStyleBackColor = true;
            this.btnZahtjeviPocetna.Click += new System.EventHandler(this.btnZahtjeviPocetna_Click);
            // 
            // btnZahtjeviProfil
            // 
            this.btnZahtjeviProfil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZahtjeviProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZahtjeviProfil.Location = new System.Drawing.Point(567, 3);
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
            this.btnZahtjeviZahtjevi.Location = new System.Drawing.Point(315, 3);
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
            this.lblZahtjevi.Location = new System.Drawing.Point(33, 94);
            this.lblZahtjevi.Name = "lblZahtjevi";
            this.lblZahtjevi.Size = new System.Drawing.Size(94, 27);
            this.lblZahtjevi.TabIndex = 5;
            this.lblZahtjevi.Text = "Zahtjevi";
            this.lblZahtjevi.Click += new System.EventHandler(this.lblPodatciProfila_Click);
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(63, 162);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowHeadersWidth = 51;
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZahtjevi.Size = new System.Drawing.Size(665, 160);
            this.dgvZahtjevi.TabIndex = 6;
            // 
            // FrmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.lblZahtjevi);
            this.Controls.Add(this.panelZahtjevi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZahtjevi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahtjevi";
            this.Load += new System.EventHandler(this.FrmZahtjevi_Load);
            this.panelZahtjevi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelZahtjevi;
        private System.Windows.Forms.Button btnZahtjeviProfil;
        private System.Windows.Forms.Button btnZahtjeviZahtjevi;
        private System.Windows.Forms.Label lblZahtjevi;
        private System.Windows.Forms.Button btnZahtjeviPocetna;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
    }
}