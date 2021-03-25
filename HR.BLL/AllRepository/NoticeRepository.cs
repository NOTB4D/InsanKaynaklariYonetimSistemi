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
    public class NoticeRepository : Connector, INotice
    {
        public List<Notice> GetAllNotice()
        {
            List<Notice> list = new List<Notice>();
            SqlCommand cmd = new SqlCommand("Select ID,BildirimTipi from tb_BildirimTipi", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Notice n = new Notice()
                {
                    ID = dr.GetInt32(0),
                    NoticeName = dr.GetString(1)
                };
                list.Add(n);
            }
            CloseConnection();
            return list;
        }

        public void Create(Notice create)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_BildirimTipi(BildirimTipi) values(@BildirimTipi)",OpenConnection());
            cmd.Parameters.AddWithValue("@BildirimTipi",create.NoticeName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from tb_BildirimTipi where ID=@id",OpenConnection());
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
