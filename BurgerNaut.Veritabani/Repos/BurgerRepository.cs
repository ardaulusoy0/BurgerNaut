using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerNaut.VarlikKatmani;
using System.Data.SqlClient;

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

        public int AddBurger(Burger burger)
        {
            string query = "INSERT INTO Burgerler (Ad,Fiyat) VALUES (@ad, @fiyat)";
            SqlCommand cmd = db.CreateCommand(query, burger.GetInsertParameters());
            return db.ExecuteNonQuery(cmd);
        }

        public int UpdtBurger(Burger burger)
        {
            /*demin ekle butonu olarak gösterdiğin yere girmiyo şuanda başka bi kod mu var yok abi */
            try
            {
                string query = "UPDATE Burgerler SET Ad = @ad, Fiyat = @fiyat WHERE Id = @id";
                SqlCommand cmd = db.CreateCommand(query, burger.GetUpdateParameters());
                return db.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                return 0;
            }

            return 0;
        }

        public int DelBurger(int burgerId)
        {
            string query = "DELETE FROM Burgerler WHERE Id = @id";
            SqlCommand cmd = db.CreateCommand(query, new List<SqlParameter> { new SqlParameter("@id", burgerId) });
            return db.ExecuteNonQuery(cmd);
        }
    }
}
