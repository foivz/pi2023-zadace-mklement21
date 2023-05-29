using DBLayer;
using HelpDesk__Matea_Klement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk__Matea_Klement.Repositories {
    public class ZahtjevRepository {
        /*
        public static Zahtjev GetZahtjevi(int id) {
            Zahtjev zahtjev = null;
            string sql = $"SELECT * FROM Zahtjevi WHERE IdZahtjev = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zahtjev;
        }
        */

        public static List<Zahtjev> GetZahtjevi() {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjevi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

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

        public static void KreirajZahtjev (Zahtjev zahtjev) {
            string sql = $"INSERT INTO Zahtjevi (ZahtjevNaslov, ZahtjevDatum, ZahtjevOpis) VALUES ('{zahtjev.ZahtjevNaslov}', GETDATE(), '{zahtjev.ZahtjevOpis}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void ObrisiZahtjev (Zahtjev zahtjev) {
            string sql = $"DELETE FROM Zahtjevi WHERE IdZahtjev ={zahtjev.IdZahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /*
        public static List<Zahtjev> GetSearchedZahtjev(List<Zahtjev> zahtjevi) {
            List<Zahtjev> pretrazivaniZahtjev = new List<Zahtjev>();
            DB.OpenConnection();
            foreach (Zahtjev zahtjev in zahtjevi) {
                string sql = $"SELECT * FROM Zahtjevi WHERE ZahtjevNaslov = {zahtjev.ZahtjevNaslov}";
                var reader = DB.GetDataReader(sql);
                while (reader.Read()) {
                    Zahtjev trazeniZahtjev = CreateObject(reader);
                    pretrazivaniZahtjev.Add(zahtjev);
                }
                reader.Close();
            }
            DB.CloseConnection();
            return pretrazivaniZahtjev;
        }
        */
        public static List<Zahtjev> GetSearchedZahtjev(string naziv) {
            List<Zahtjev> pretrazivaniZahtjev = new List<Zahtjev>();
            DB.OpenConnection();
            foreach (Zahtjev zahtjev in pretrazivaniZahtjev) {
                string sql = $"SELECT * FROM Zahtjevi WHERE ZahtjevNaslov LIKE '{naziv}'";
                var reader = DB.GetDataReader(sql);
                while (reader.Read()) {
                    Zahtjev trazeniZahtjev = CreateObject(reader);
                    pretrazivaniZahtjev.Add(zahtjev);
                }
                reader.Close();
            }
            DB.CloseConnection();
            return pretrazivaniZahtjev;
            /*
            List<Zahtjev> zahtjev = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjevi WHERE ZahtjevNaslov = '{naziv}'";
            //string sql = $"SELECT * FROM Zahtjevi WHERE ZahtjevNaziv = {naziv}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.Read()) {
                Zahtjev pretrazivani = CreateObject(reader);
                zahtjev.Add(pretrazivani);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjev;
            */
        }
    }
}
