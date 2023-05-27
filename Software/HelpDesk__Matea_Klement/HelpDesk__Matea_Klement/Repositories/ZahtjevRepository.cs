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

            var zahtjev = new Zahtjev {
                IdZahtjev = id,
                ZahtjevNaslov = naslov,
                Status = status,
                ZahtjevDatum = datum
            }; //spajanje sa Zahtjev.cs
            return zahtjev;
        }
    }
}
