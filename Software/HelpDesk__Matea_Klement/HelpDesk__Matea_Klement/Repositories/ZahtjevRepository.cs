using DBLayer;
using HelpDesk__Matea_Klement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Repositories {
    //klasa ZahtjevRepository dohvaća zapise o Zahtjevima iz baze te pretvara sve zapise u objekt tipa zahtjevi
    public class ZahtjevRepository {
        /// <summary>
        /// klasa GetZahtjeviKorisnika koja uzima sve zahtjeve od logiranog korisnika te iz zapisuje u listu i vraća zapis liste
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Zahtjev> GetZahtjeviKorisnika(int id) {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjevi WHERE IdKorisnik = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev evaluation = CreateObject(reader);
                zahtjevi.Add(evaluation);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

        /// <summary>
        /// metoda za mapiranje atributa objekta tipa Zahtjev
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Zahtjev CreateObject (SqlDataReader reader) {
            int id = int.Parse(reader["IdZahtjev"].ToString());
            string naslov = reader["ZahtjevNaslov"].ToString();
            string status = reader["Status"].ToString();
            DateTime datum = DateTime.Parse(reader["ZahtjevDatum"].ToString());
            string opis = reader["ZahtjevOpis"].ToString();

            var zahtjev = new Zahtjev {
                IdZahtjev = id,
                ZahtjevNaslov = naslov,
                Status = status,
                ZahtjevOpis = opis,
                ZahtjevDatum = datum
            }; //spajanje sa Zahtjev.cs
            return zahtjev;
        }

        /// <summary>
        /// metoda za kreiranje novog zahtjeva logiranog korisnika koja izvršaval SQL naredbu za unos novog zapisa u bazu
        /// </summary>
        /// <param name="zahtjev"></param>
        public static void KreirajZahtjev (Zahtjev zahtjev) {
            var korisnik = FrmPrijava.LogiraniKorisnik;
            string sql = $"INSERT INTO Zahtjevi (ZahtjevNaslov, ZahtjevDatum, ZahtjevOpis, IdKorisnik) VALUES ('{zahtjev.ZahtjevNaslov}', GETDATE(), '{zahtjev.ZahtjevOpis}', '{korisnik.IdKorisnik}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /// <summary>
        /// metoda za brisanje zahtjeva koja izvršaval SQL naredbu za brisanje zapisa iz baze
        /// </summary>
        /// <param name="zahtjev"></param>
        public static void ObrisiZahtjev (Zahtjev zahtjev) {
            string sql = $"DELETE FROM Zahtjevi WHERE IdZahtjev ={zahtjev.IdZahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /// <summary>
        /// metoda za pretraživanje zahtjeva po nazivu, izvršaval SQL naredbu za pretraživanje zapisa iz baze
        /// </summary>
        /// <param name="naziv"></param>
        /// <returns></returns>
        public static List<Zahtjev> GetSearchedZahtjev(string naziv) {
            var korisnik = FrmPrijava.LogiraniKorisnik;
            List<Zahtjev> pretrazivaniZahtjev = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjevi WHERE IdKorisnik = '{korisnik.IdKorisnik}' AND ZahtjevNaslov LIKE '%{naziv}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                pretrazivaniZahtjev.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return pretrazivaniZahtjev;

        }
    }
}
