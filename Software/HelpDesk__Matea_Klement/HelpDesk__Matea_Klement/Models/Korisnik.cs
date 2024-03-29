﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Models {
    /// <summary>
    /// klasa Korisnik, njezini atributi, metoda ToString() za ispis kombinacije imena i prezimena sa razmakom
    /// </summary>
    public class Korisnik {
        public int IdKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojMobitela { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string Email { get; set; }

        public override string ToString() {
            return Ime + " " + Prezime;
        }
        
        public bool ProvjeriLozinku(string lozinka) {
            return Lozinka == lozinka;
        }
    }
}
