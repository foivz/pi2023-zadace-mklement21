namespace HelpDesk__Matea_Klement {
    partial class FrmKreirajZahtjev {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKreirajZahtjev));
            this.lblNoviZahtjev = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtNoviOpis = new System.Windows.Forms.TextBox();
            this.txtNoviNaslov = new System.Windows.Forms.TextBox();
            this.btnKreiranjeSpremi = new System.Windows.Forms.Button();
            this.btnKreiranjeOdustani = new System.Windows.Forms.Button();
            this.lblNoviDatum = new System.Windows.Forms.Label();
            this.dtpNoviDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNoviZahtjev
            // 
            this.lblNoviZahtjev.AutoSize = true;
            this.lblNoviZahtjev.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNoviZahtjev.Location = new System.Drawing.Point(31, 24);
            this.lblNoviZahtjev.Name = "lblNoviZahtjev";
            this.lblNoviZahtjev.Size = new System.Drawing.Size(139, 27);
            this.lblNoviZahtjev.TabIndex = 6;
            this.lblNoviZahtjev.Text = "Novi zahtjev";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(33, 58);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(50, 16);
            this.lblNaslov.TabIndex = 7;
            this.lblNaslov.Text = "Naslov";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(33, 174);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(96, 16);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Opis problema";
            // 
            // txtNoviOpis
            // 
            this.txtNoviOpis.Location = new System.Drawing.Point(36, 193);
            this.txtNoviOpis.Multiline = true;
            this.txtNoviOpis.Name = "txtNoviOpis";
            this.txtNoviOpis.Size = new System.Drawing.Size(274, 79);
            this.txtNoviOpis.TabIndex = 9;
            // 
            // txtNoviNaslov
            // 
            this.txtNoviNaslov.Location = new System.Drawing.Point(36, 77);
            this.txtNoviNaslov.Name = "txtNoviNaslov";
            this.txtNoviNaslov.Size = new System.Drawing.Size(100, 22);
            this.txtNoviNaslov.TabIndex = 10;
            // 
            // btnKreiranjeSpremi
            // 
            this.btnKreiranjeSpremi.Location = new System.Drawing.Point(457, 246);
            this.btnKreiranjeSpremi.Name = "btnKreiranjeSpremi";
            this.btnKreiranjeSpremi.Size = new System.Drawing.Size(75, 26);
            this.btnKreiranjeSpremi.TabIndex = 11;
            this.btnKreiranjeSpremi.Text = "Spremi";
            this.btnKreiranjeSpremi.UseVisualStyleBackColor = true;
            this.btnKreiranjeSpremi.Click += new System.EventHandler(this.btnKreiranjeSpremi_Click);
            // 
            // btnKreiranjeOdustani
            // 
            this.btnKreiranjeOdustani.Location = new System.Drawing.Point(347, 246);
            this.btnKreiranjeOdustani.Name = "btnKreiranjeOdustani";
            this.btnKreiranjeOdustani.Size = new System.Drawing.Size(85, 26);
            this.btnKreiranjeOdustani.TabIndex = 12;
            this.btnKreiranjeOdustani.Text = "Odustani";
            this.btnKreiranjeOdustani.UseVisualStyleBackColor = true;
            this.btnKreiranjeOdustani.Click += new System.EventHandler(this.btnKreiranjeOdustani_Click);
            // 
            // lblNoviDatum
            // 
            this.lblNoviDatum.AutoSize = true;
            this.lblNoviDatum.Location = new System.Drawing.Point(33, 118);
            this.lblNoviDatum.Name = "lblNoviDatum";
            this.lblNoviDatum.Size = new System.Drawing.Size(46, 16);
            this.lblNoviDatum.TabIndex = 13;
            this.lblNoviDatum.Text = "Datum";
            // 
            // dtpNoviDatum
            // 
            this.dtpNoviDatum.Location = new System.Drawing.Point(36, 137);
            this.dtpNoviDatum.Name = "dtpNoviDatum";
            this.dtpNoviDatum.Size = new System.Drawing.Size(159, 22);
            this.dtpNoviDatum.TabIndex = 15;
            // 
            // FrmKreirajZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 287);
            this.Controls.Add(this.dtpNoviDatum);
            this.Controls.Add(this.lblNoviDatum);
            this.Controls.Add(this.btnKreiranjeOdustani);
            this.Controls.Add(this.btnKreiranjeSpremi);
            this.Controls.Add(this.txtNoviNaslov);
            this.Controls.Add(this.txtNoviOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblNoviZahtjev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKreirajZahtjev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje zahtjeva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoviZahtjev;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtNoviOpis;
        private System.Windows.Forms.TextBox txtNoviNaslov;
        private System.Windows.Forms.Button btnKreiranjeSpremi;
        private System.Windows.Forms.Button btnKreiranjeOdustani;
        private System.Windows.Forms.Label lblNoviDatum;
        private System.Windows.Forms.DateTimePicker dtpNoviDatum;
    }
}