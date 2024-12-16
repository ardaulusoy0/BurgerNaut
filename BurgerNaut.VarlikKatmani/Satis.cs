using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BurgerNaut.VarlikKatmani.Base;

namespace BurgerNaut.VarlikKatmani
{
    public class Satis : IModel
    {
        public int Id { get; set; }
        public string MenuDetay { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }

        public string DispName => $"{Id} - {Tarih.Day}/{Tarih.Month}/{Tarih.Year}";
        public override string ToString()
        {
            return $"{Id} - {Tarih.Day}/{Tarih.Month}/{Tarih.Year}";
        }

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
                new SqlParameter("@detay", this.MenuDetay),
                new SqlParameter("@tarih", this.Tarih),
                new SqlParameter("@fiyat", this.Tutar),
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            return new List<SqlParameter>
            {
                new SqlParameter("@id", this.Id),
                new SqlParameter("@detay", this.MenuDetay),
                new SqlParameter("@tarih", this.Tarih),
                new SqlParameter("@fiyat", this.Tutar),
            };
        }

        public void Read(SqlDataReader reader)
        {
            Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;
            MenuDetay = reader["MenuDetay"] != DBNull.Value ? reader["MenuDetay"].ToString() : "Detay Yok";
            Tarih = reader["Tarih"] != DBNull.Value ? Convert.ToDateTime(reader["Tarih"]) : DateTime.Now;
            Tutar = reader["Tutar"] != DBNull.Value ? Convert.ToDecimal(reader["Tutar"]) : 0;
        }


    }
}
