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
        //klasa GetZahtjeviKorisnika koja uzima sve zahtjeve od logiranog korisnika te iz zapisuje u listu i vraća zapis liste
        public static List<Zahtjev> GetZahtjeviKorisnika(int id) {
            List<Zahtjev> evaluations = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjevi WHERE IdKorisnik = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev evaluation = CreateObject(reader);
                evaluations.Add(evaluation);
            }
            reader.Close();
            DB.CloseConnection();
            return evaluations;
        }

        //metoda za mapiranje atributa objetka tipa Zahtjev
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

        //metoda za kreiranje novog zahtjeva koja izvršaval SQL naredbu za unos novog zapisa u bazu
        public static void KreirajZahtjev (Zahtjev zahtjev) {
            var korisnik = FrmPrijava.LogiraniKorisnik;
            string sql = $"INSERT INTO Zahtjevi (ZahtjevNaslov, ZahtjevDatum, ZahtjevOpis, IdKorisnik) VALUES ('{zahtjev.ZahtjevNaslov}', GETDATE(), '{zahtjev.ZahtjevOpis}', '{korisnik.IdKorisnik}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        //metoda za brisanje zahtjeva koja izvršaval SQL naredbu za brisanje zapisa iz baze
        public static void ObrisiZahtjev (Zahtjev zahtjev) {
            string sql = $"DELETE FROM Zahtjevi WHERE IdZahtjev ={zahtjev.IdZahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        //metoda za pretraživanje zahtjeva po nazivu, izvršaval SQL naredbu za pretraživanje zapisa iz baze
        public static List<Zahtjev> GetSearchedZahtjev(string naziv) {
            List<Zahtjev> pretrazivaniZahtjev = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjevi WHERE ZahtjevNaslov LIKE '%{naziv}%'";
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
