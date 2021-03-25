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
    public class CompanyListRepository : Connector, ICompany
    {

        public List<Company> List()
        {
            List<Company> list = new List<Company>();
            SqlCommand cmd = new SqlCommand("Select ID,SirketAdi from tb_Sirketler", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Company()
                {
                     ID=dr.GetInt32(0),
                      Name=dr.GetString(1)
                });
            }
            CloseConnection();

            return list;
        }
    }
}
