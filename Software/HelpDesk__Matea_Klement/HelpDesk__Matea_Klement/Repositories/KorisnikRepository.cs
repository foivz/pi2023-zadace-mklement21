using DBLayer;
using HelpDesk__Matea_Klement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Repositories {
    /// <summary>
    /// klasa KorisnikRepoitory dohvaća zapise o Korisnicima iz baze te pretvara sve zapise u objekt tipa korisnik
    /// </summary>
    public class KorisnikRepository {
        /// <summary>
        /// metoda za dohvaćanje podataka logiranog korisnika preko korisničkog imena
        /// </summary>
        /// <param name="korisnickoIme"></param>
        /// <returns></returns>
        public static Korisnik GetKorisnik(string korisnickoIme) {
            string sql = $"SELECT * FROM Korisnici WHERE KorisnickoIme = '{korisnickoIme}'";
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

        /// <summary>
        /// metoda za dohvaćanje jednog korisnika po njegovom id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Korisnik GetKorisnik(int id) {
            string sql = $"SELECT * FROM Korisnici WHERE IdKorisnik = {id}";
            Korisnik korisnik = null;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            } //if
            DB.CloseConnection();
            return korisnik;
        }

        /// <summary>
        /// metoda za mapiranje atributa objekta tipa Korisnik
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Korisnik CreateObject (SqlDataReader reader) {
            string ime = reader["Ime"].ToString();
            int id = int.Parse(reader["IdKorisnik"].ToString());
           
            string prezime = reader["Prezime"].ToString();
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string broj = reader["BrojMobitela"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string email = reader["Email"].ToString();


            var korisnik = new Korisnik {
                IdKorisnik = id,
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoIme,
                BrojMobitela = broj,
                Lozinka = lozinka,
                Email = email
            };
            return korisnik;
        }

        /// <summary>
        /// metoda nad repozitorijem koja ažurira zapis u bazi, izvršava SQL naredbu za ažuriranje korisnika
        /// </summary>
        /// <param name="korisnik"></param>
        public void AzurirajKorisnika (Korisnik korisnik) {
            string sql = $"UPDATE Korisnici " + $"SET BrojMobitela = '{korisnik.BrojMobitela}', KorisnickoIme = '{korisnik.KorisnickoIme}', Email = '{korisnik.Email}', Lozinka = '{korisnik.Lozinka}' WHERE IdKorisnik = {korisnik.IdKorisnik}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
