using BurgerNaut.VarlikKatmani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BurgerNaut.Veritabani;


namespace BurgerNaut.Veritabani.Repos
{
    public class SatisRepository
    {
        private readonly DBAccess<Satis> db;

        public SatisRepository()
        {
            db = new DBAccess<Satis>();
        }
        public List<Satis> GetSatis()
        {
            string query = "SELECT * FROM Satislar";
            SqlCommand cmd = db.CreateCommand(query);
            return db.ToList(cmd);
        }

        public int AddSatis(Satis satis)
        {
            string query = "INSERT INTO Satislar (Tarih,Tutar,MenuDetay) VALUES (@tarih,@fiyat, @detay)";
            SqlCommand cmd = db.CreateCommand(query, satis.GetInsertParameters());
            return db.ExecuteNonQuery(cmd);
        }

        public int DelSatis(int detayId)
        {
            string query = "DELETE FROM Satislar WHERE Id = @id";
            SqlCommand cmd = db.CreateCommand(query, new List<SqlParameter> { new SqlParameter("@id", detayId) });
            return db.ExecuteNonQuery(cmd);
        }
    }
}
