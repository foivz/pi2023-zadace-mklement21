using DBLayer;
using HelpDesk__Matea_Klement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Repositories {
    public class KorisnikRepository {
        public static Korisnik GetKorisnik(int id) {
            Korisnik korisnik = null;

            string sql = $"SELECT * FROM Korisnici WHERE IdKorisnik = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            } //if
            DB.CloseConnection();
            return FetchKorisnik(sql);
        }

        public static List<Korisnik> GetKorisnici() {
            List<Korisnik> korisnici = new List<Korisnik>();
            string sql = $"SELECT * FROM Korisnici";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Korisnik korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }
            reader.Close();
            DB.CloseConnection();
            return korisnici;
        }

        private static Korisnik CreateObject (SqlDataReader reader) {
            int id = int.Parse(reader["IdKorisnik"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string broj = reader["BrojMobitela"].ToString();
            string lozinka = reader["Lozinka"].ToString();


            var korisnik = new Korisnik {
                IdKorisnik = id,
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoIme,
                BrojMobitela = broj,
                Lozinka = lozinka
            };
            return korisnik;
        }

        
        public static Korisnik GetKorisnik (string korisnickoIme) {
            string sql = $"SELECT * FROM Korisnici WHERE KorisnickoIme = '{korisnickoIme}'";
            return FetchKorisnik(sql);
        }

        private static Korisnik FetchKorisnik(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Korisnik korisnik = null;
            if (reader.HasRows == true) {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return korisnik;
        }

        public void AzurirajKorisnika (Korisnik korisnik) {
            string sql = $"UPDATE Korisnici " + $"SET BrojMobitela = '{korisnik.BrojMobitela}', KorisnickoIme = '{korisnik.KorisnickoIme}' WHERE IdKorisnik = {4}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}
