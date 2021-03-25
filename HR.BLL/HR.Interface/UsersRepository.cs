using HR.BLL.HR.Interface;
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
    public class UsersRepository : Connector , IUsers
    {
        public void create(Users usr)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_Kullanicilar(Ad,Soyad,Email,Sifre,AdminMi) values(@Ad,@Soyad,@Email,@Sifre,@AdminMi)", OpenConnection());
            cmd.Parameters.AddWithValue("@Ad", usr.Ad);
            cmd.Parameters.AddWithValue("@Soyad", usr.Soyad);
            cmd.Parameters.AddWithValue("@Email", usr.Email);
            cmd.Parameters.AddWithValue("@Sifre", usr.Sifre);
            cmd.Parameters.AddWithValue("@AdminMi", usr.AdminMi);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

       
    }
}
