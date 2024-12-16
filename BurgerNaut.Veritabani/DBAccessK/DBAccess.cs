using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerNaut.VarlikKatmani.Base;

namespace BurgerNaut.Veritabani
{
    public class DBAccess<T> where T : IModel
    {
        private readonly SqlConnection connection;

        public DBAccess()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arda\Desktop\BurgerNaut_FINAL\BurgerNaut\BurgerNaut.Sunum\Database1.mdf;Integrated Security=True");

        }

        private void ConnAc()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void ConnKapat()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlCommand CreateCommand(string sorgu)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sorgu;
            cmd.CommandType = CommandType.Text;

            return cmd;

        }

        public SqlCommand CreateCommand(string sorgu, List<SqlParameter> param)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sorgu;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(param.ToArray());

            return cmd;
        }

        public List<T> ToList(SqlCommand cmd)
        {
            List<T> items = new List<T>();
            ConnAc();

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                T item = (T)Activator.CreateInstance(typeof(T));
                item.Read(read);
                items.Add(item);
            }
            ConnKapat();
            return items;
        }

        public List<T> ToList<T>(SqlCommand cmd) where T: IModel, new()
        {
            List<T> items = new List<T>();
            ConnAc();
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                T item = new T();
                item.Read(read);
                items.Add(item);
            }
            ConnKapat();
            return items;
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            ConnAc();
            var res = cmd.ExecuteScalar();
            ConnKapat();

            return res;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            ConnAc();
            int res = cmd.ExecuteNonQuery();
            ConnKapat();

            return res;
        }

       

    }
}
