using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Models {
    public abstract class Korisnik {
        public int IdKorisnik { get; set; }
        public string Email { get; set; }
        public string BrojMobitela { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string LozinkaNova { get; set; }
    }
}
