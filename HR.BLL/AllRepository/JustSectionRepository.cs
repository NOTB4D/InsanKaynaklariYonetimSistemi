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
 public   class JustSectionRepository : Connector , IJustSection
    {
        public List<JustSection> List()
        {
            List<JustSection> list = new List<JustSection>();
            SqlCommand cmd = new SqlCommand(" Select ID,SubeAdi From tb_Subeler",OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                JustSection js = new JustSection()
                {
                    ID = dr.GetInt32(0),
                    Name = dr.GetString(1)

                };
                list.Add(js);


            }
            CloseConnection();
            return list;
        }
    }
}
