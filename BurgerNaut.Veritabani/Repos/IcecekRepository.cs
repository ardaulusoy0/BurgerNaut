using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerNaut.VarlikKatmani;
using System.Data.SqlClient;


namespace BurgerNaut.Veritabani.Repos
{
    public class IcecekRepository
    {
        private readonly DBAccess<Icecek> db;

        public IcecekRepository()
        {
            db = new DBAccess<Icecek>();
        }

        public List<Icecek> GetIceceks()
        {
            string query = "SELECT * FROM Icecekler";
            SqlCommand cmd = db.CreateCommand(query);
            return db.ToList(cmd);
        }

        public List<Burger> GetIcecekPriceByName(string name)
        {
            string query = "SELECT Id,Fiyat FROM Icecekler WHERE Ad = @ad";
            SqlCommand cmd = db.CreateCommand(query);
            cmd.Parameters.AddWithValue("@ad", name);

            return db.ToList<Burger>(cmd);
        }

        public int AddIcecek(Icecek icecek)
        {
            string query = "INSERT INTO Icecekler (Ad,Fiyat) VALUES (@ad, @fiyat)";
            SqlCommand cmd = db.CreateCommand(query, icecek.GetInsertParameters());
            return db.ExecuteNonQuery(cmd);
        }

        public int UpdtIcecek(Icecek icecek)
        {
            string query = "UPDATE Icecekler SET Ad = @ad, Fiyat = @fiyat WHERE Id = @id";
            SqlCommand cmd = db.CreateCommand(query, icecek.GetUpdateParameters());
            return db.ExecuteNonQuery(cmd);
        }

        public int DelIcecek(int icecekId)
        {
            string query = "DELETE FROM Icecekler WHERE Id = @id";
            SqlCommand cmd = db.CreateCommand(query, new List<SqlParameter> { new SqlParameter("@id", icecekId) });
            return db.ExecuteNonQuery(cmd);
        }
    }
}
