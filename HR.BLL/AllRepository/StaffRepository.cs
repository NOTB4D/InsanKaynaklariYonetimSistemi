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
    public class StaffRepository : Connector , IStaff
    {
        /// <summary>
        /// Bütün kadroları listeler.
        /// </summary>
        /// <returns></returns>
        public List<Staff> GetAllStaff()
        {
            List<Staff> list = new List<Staff>();

            SqlCommand cmd = new SqlCommand("SELECT [ID] ,[PersonelSayisi],[SubeID] FROM [InsanKaynaklari].[dbo].[tb_Kadro]",OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Staff s = new Staff() { 
                 ID=dr.GetInt32(0),
                  StaffCount=dr.GetInt32(1),
                 SectionID = dr.GetInt32(2)
                };
                list.Add(s);
            }

            CloseConnection();

            return list;
        }
        /// <summary>
        /// Yeni bir kadro oluşturur.(Personel sayısı eklenir.)
        /// </summary>
        /// <param name="staff"></param>
        public void Create(Staff staff)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_Kadro(PersonelSayisi,SubeID) values(@PersonelSayisi,@SubeID)",OpenConnection());
            cmd.Parameters.AddWithValue("@PersonelSayisi",staff.StaffCount);
            cmd.Parameters.AddWithValue("@SubeID", staff.SectionID);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// ID'ye göre kadro sayıları silinir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from tb_Kadro where SubeID=@id",OpenConnection());

            cmd.Parameters.AddWithValue("@id",id);
            int effectedRow = cmd.ExecuteNonQuery();

            CloseConnection();
            return effectedRow;
        }

        /// <summary>
        /// Update işlemi için gerekli olan değerleri tek bir veri şeklinde geri taşır.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Staff GetOneValue(Staff s)
        {
            Staff staff = new Staff();

            SqlCommand cmd = new SqlCommand("Select ID ,PersonelSayisi,SubeID FROM tb_Kadro where SubeID=@id",OpenConnection());

            cmd.Parameters.AddWithValue("@id", s.SectionID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                staff = new Staff()
                {
                    ID = dr.GetInt32(0),
                    StaffCount = dr.GetInt32(1),
                    SectionID = dr.GetInt32(2)
                };
            }

            CloseConnection();

            return staff;
        }

        /// <summary>
        /// Personel sayısının güncellenme işlemi yapılır.
        /// </summary>
        /// <param name="s"></param>
        public void Update(Staff s)
        {
            SqlCommand cmd=new SqlCommand("Update tb_Kadro set PersonelSayisi=@pSayi where SubeID=@id",OpenConnection());
            cmd.Parameters.AddWithValue("@pSayi", s.StaffCount); 
            cmd.Parameters.AddWithValue("@id", s.SectionID);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
