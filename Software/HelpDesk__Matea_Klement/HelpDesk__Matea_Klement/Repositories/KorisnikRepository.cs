using DBLayer;
using HelpDesk__Matea_Klement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Repositories {
    //klasa KorisnikRepoitory dohvaća zapise o Korisnicima iz baze te pretvara sve zapise u objekt tipa korisnik
    public class KorisnikRepository {

        //metoda za dohvaćanje jednog korisnika po njegovom id
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

        //metoda za mapiranje atributa objetka tipa Korisnik
        private static Korisnik CreateObject (SqlDataReader reader) {
            string ime = reader["Ime"].ToString();
            int id = int.Parse(reader["IdKorisnik"].ToString());
           
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

        //metoda nad prepozitorijem koja ažurira zapis u bazi, izvršava SQL naredbu za ažuriranje korisnika
        public void AzurirajKorisnika (Korisnik korisnik) {
            string sql = $"UPDATE Korisnici " + $"SET BrojMobitela = '{korisnik.BrojMobitela}', KorisnickoIme = '{korisnik.KorisnickoIme}' WHERE IdKorisnik = {korisnik.IdKorisnik}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
