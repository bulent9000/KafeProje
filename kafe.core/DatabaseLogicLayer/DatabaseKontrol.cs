using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafe.core.DatabaseLogicLayer
{
    public class DatabaseKontrol
    {
        public SqlCommand cmd;
        public SqlConnection con;
        public SqlDataReader reader;
        public int returnValue = 0;
        public object returnObject;


        public DatabaseKontrol()
        {
            con = new SqlConnection(connectionStringOlustur());
        }
        string connectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            #region
            builder.DataSource = "DESKTOP-1PBLKBH\\SQLEXPRESS";
            builder.InitialCatalog = "KafeSiparis";
            builder.UserID = "sa";
            builder.Password = "12345";
            #endregion
            return builder.ConnectionString;
        }
        public void baglantiayarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }

        }
        public object kolonGetir(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiayarla();
            returnObject = cmd.ExecuteScalar();
            baglantiayarla();
            return returnObject;
        }

        #region Listeleri Db ye gönderme
        public void yiyecekEkleme(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            cmd.ExecuteNonQuery();
            baglantiayarla();

        }
        public SqlDataReader yiyecekListele(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            return cmd.ExecuteReader();


        }
        public void icecekEkleme(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            cmd.ExecuteNonQuery();
            baglantiayarla();

        }
        public SqlDataReader icecekListele(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            return cmd.ExecuteReader();


        }

        public void tatliEkleme(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            cmd.ExecuteNonQuery();
            baglantiayarla();

        }
        public SqlDataReader tatliListele(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            return cmd.ExecuteReader();


        }
        #endregion
    }
}
