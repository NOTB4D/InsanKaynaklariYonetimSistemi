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
    public class EducationCompanyRepository : Connector, IEducationCompany
    {
        /// <summary>
        /// Kurum bilgisi isimlerini listesini getirir.
        /// </summary>
        /// <returns></returns>
        public List<EducationCompany> List()
        {
            List<EducationCompany> list = new List<EducationCompany>();
            SqlCommand cmd = new SqlCommand("Select ID,KurumAdi from tb_EgitimiVerenKurum", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EducationCompany edu = new EducationCompany()
                {
                    ID = dr.GetInt32(0),
                    Name = dr.GetString(1)
                };
                list.Add(edu);
            }
            CloseConnection();
            return list;

        }

        /// <summary>
        /// Yeni bir eğitim kurumu bilgisini oluşturur.
        /// </summary>
        /// <param name="create"></param>
        public void Create(EducationCompany create)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_EgitimiVerenKurum(KurumAdi)Values(@kurumAdi)", OpenConnection());
            cmd.Parameters.AddWithValue("@kurumAdi", create.Name);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// Kurum adı bilgisini günceller.
        /// </summary>
        /// <param name="update"></param>
        public void Update(EducationCompany update)
        {
            SqlCommand cmd = new SqlCommand("Update tb_EgitimiVerenKurum set KurumAdi=@ad WHERE ID=@id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", update.ID);
            cmd.Parameters.AddWithValue("@ad", update.Name);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// Update için geriye tek bir kurum adı bilgisini getirir.
        /// </summary>
        /// <param name="ed"></param>
        /// <returns></returns>
        public EducationCompany GetOneValue(EducationCompany ed)
        {
            SqlCommand cmd = new SqlCommand("Select ID,KurumAdi from tb_EgitimiVerenKurum Where ID=@id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", ed.ID);
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            EducationCompany edu = new EducationCompany()
            {
                ID = dr.GetInt32(0),
                Name = dr.GetString(1)
            };

            CloseConnection();
            return edu;
        }
    }
}
