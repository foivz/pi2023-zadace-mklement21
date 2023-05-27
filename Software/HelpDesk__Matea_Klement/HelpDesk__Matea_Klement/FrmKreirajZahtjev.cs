using HelpDesk__Matea_Klement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk__Matea_Klement {
    public partial class FrmKreirajZahtjev : Form {
        private Zahtjev zahtjev;
        public FrmKreirajZahtjev(Models.Zahtjev selectedZahtjev) {
            InitializeComponent();
            zahtjev = selectedZahtjev;
        }
    }
}
