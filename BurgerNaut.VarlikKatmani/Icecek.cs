using BurgerNaut.VarlikKatmani.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerNaut.VarlikKatmani
{
    public class Icecek : IModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public string DispName => $"{Ad} - {Fiyat:C2}";

        public List<SqlParameter> GetDeleteParameters()
        {
            return new List<SqlParameter>
            {
                new SqlParameter("@id", this.Id)
            };
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter>
            {
                new SqlParameter("@id", this.Id),
                new SqlParameter("@ad", this.Ad),
                new SqlParameter("@fiyat", this.Fiyat),

            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            return new List<SqlParameter>
            {
                new SqlParameter("@ad", this.Ad),
                new SqlParameter("@fiyat", this.Fiyat),
                new SqlParameter("@id", this.Id),

            };
        }

        public void Read(SqlDataReader reader)
        {
            Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;
            Ad = reader["Ad"] != DBNull.Value ? reader["Ad"].ToString() : "Burger Adı Yok";
            Fiyat = reader["Fiyat"] != DBNull.Value ? Convert.ToDecimal(reader["Fiyat"]) : 0;
        }
    }
}
