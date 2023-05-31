﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Models {
    /// <summary>
    /// klasa Zahtjev i njezini atributi
    /// </summary>
    public class Zahtjev {
        public int IdZahtjev { get; set; }
        public string ZahtjevNaslov { get; set; }
        public string Status { get; set; }
        public string ZahtjevOpis { get; set; }
        public DateTime ZahtjevDatum { get; set; }
    }
}
