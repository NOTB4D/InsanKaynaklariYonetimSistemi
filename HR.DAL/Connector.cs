using System.Data.SqlClient;
using System.Data;

namespace HR.DAL
{
    public class Connector
    {
        //SqlConnection cnn = new SqlConnection("Server=.;database=InsanKaynaklari;trusted_connection=true;");
        SqlConnection cnn = new SqlConnection("Server=94.73.145.7;database=DB140418123453;User ID=USR140418123453;pwd=PSS!X4P8V2%;Integrated Security=false;");
        /// <summary>
        /// Sql Connection bağlanma
        /// </summary>
        /// <returns></returns>
        protected SqlConnection OpenConnection()
        {
            if (cnn.State == ConnectionState.Closed)

                cnn.Open();
            return cnn;
        }
        /// <summary>
        /// Sql connection kapatma 
        /// </summary>
        protected void CloseConnection()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
    }
}
