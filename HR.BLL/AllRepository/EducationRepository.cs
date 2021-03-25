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
    public class EducationRepository : Connector, IEducation
    {
        /// <summary>
        /// Eğitim isimlerini bilgilerini listeler.
        /// </summary>
        /// <returns></returns>
        public List<Education> List()
        {
            List<Education> list = new List<Education>();

            SqlCommand cmd = new SqlCommand("Select ID,EgitimAdi from  tb_Egitimler", OpenConnection());
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Education edu = new Education()
                    {
                        ID = dr.GetInt32(0),
                        EducationName = dr.GetString(1)
                    };
                    list.Add(edu);
                }
                return list;
            }

        }
        /// <summary>
        /// Yeni bir eğtim adı bilgisi eklenir.
        /// </summary>
        /// <param name="create"></param>
        public void Create(Education create)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_Egitimler(EgitimAdi,EgitimSeviyesi) values(@EgitimAdi,@EgitimSeviyesi)", OpenConnection());
            cmd.Parameters.AddWithValue("@EgitimAdi", create.EducationName);
            cmd.Parameters.AddWithValue("@EgitimSeviyesi", create.EducationLevel);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
        /// <summary>
        /// Eğitim adı bilgisini güncellemek için kullanılır.
        /// </summary>
        /// <param name="update"></param>
        public void Update(Education update)
        {
            SqlCommand cmd = new SqlCommand("Update tb_Egitimler set EgitimAdi=@egitimAdi,EgitimSeviyesi=@EgitimSeviyesi where ID=@id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", update.ID);
            cmd.Parameters.AddWithValue("@egitimAdi", update.EducationName);
            cmd.Parameters.AddWithValue("@EgitimSeviyesi", update.EducationLevel);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
        /// <summary>
        /// Update için gerekli olan geriye tek bir değer geriye getirir.
        /// </summary>
        /// <param name="edu"></param>
        /// <returns></returns>
        public Education GetOneValue(Education edu)
        {
            SqlCommand cmd = new SqlCommand("Select ID,EgitimAdi from  tb_Egitimler Where ID=@id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", edu.ID);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                    Education education = new Education()
                    {
                        ID = dr.GetInt32(0),
                        EducationName = dr.GetString(1)
                    };
                return education;
            }
        }
    }
}
