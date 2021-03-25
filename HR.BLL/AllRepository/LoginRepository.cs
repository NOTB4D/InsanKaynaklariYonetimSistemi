using HR.DAL;
using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.AllRepository
{
    public class LoginRepository : Connector
    {
        /// <summary>
        /// Email,Sifre ve AdminMi bilgisine göre uygulamaya giriş işlemi gerçekleşir.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="sifre"></param>
        /// <param name="AdminMi"></param>
        /// <returns></returns>
        public Login Login(string email, string sifre, bool AdminMi)
        {
            Login login = null;
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(sifre))
            {
                SqlCommand cmd = new SqlCommand("Select Email,Sifre,AdminMi from tb_Kullanicilar where Email=@mail and Sifre=@sifre and AdminMi=1", OpenConnection());

                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    if (dr.HasRows)
                    {
                        dr.Read();
                        login = new Login()
                        {
                            Email = dr.GetString(0),
                            Sifre = dr.GetString(1),
                            AdminMi = dr.GetBoolean(2)
                        };
                        CloseConnection();
                    }
                }

            }
            return login;
        }
    }
}
