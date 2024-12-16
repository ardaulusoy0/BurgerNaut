using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerNaut.VarlikKatmani;
using System.Data.SqlClient;
using BurgerNaut.Veritabani;

namespace BurgerNaut.Veritabani.Repos
{
    public class BurgerRepository 
    {
        private readonly DBAccess<Burger> db;

        public BurgerRepository()
        {
            db = new DBAccess<Burger>();
        }

        public List<Burger> GetBurgers()
        {
            string query = "SELECT * FROM Burgerler";
            SqlCommand cmd = db.CreateCommand(query);
            return db.ToList(cmd);
        }

        public List<Burger> GetBurgerPriceByName(string name)
        {
            string query = "SELECT Id,Fiyat FROM Burgerler WHERE Ad = @ad";
            SqlCommand cmd = db.CreateCommand(query);
            cmd.Parameters.AddWithValue("@ad", name);

            return db.ToList<Burger>(cmd);
        }



        public int AddBurger(Burger burger)
        {
            string query = "INSERT INTO Burgerler (Ad,Fiyat) VALUES (@ad, @fiyat)";
            SqlCommand cmd = db.CreateCommand(query, burger.GetInsertParameters());
            return db.ExecuteNonQuery(cmd);
        }

        public int UpdtBurger(Burger burger)
        {
            string query = "UPDATE Burgerler SET Ad = @ad, Fiyat = @fiyat WHERE Id = @id";
            SqlCommand cmd = db.CreateCommand(query, burger.GetUpdateParameters());
            return db.ExecuteNonQuery(cmd);
        }

        public int DelBurger(int burgerId)
        {
            string query = "DELETE FROM Burgerler WHERE Id = @id";
            SqlCommand cmd = db.CreateCommand(query, new List<SqlParameter> { new SqlParameter("@id", burgerId) });
            return db.ExecuteNonQuery(cmd);
        }
    }
}
