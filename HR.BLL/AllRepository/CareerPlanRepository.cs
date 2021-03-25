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
    public class CareerPlanRepository : Connector, ICareerPlan
    {
        /// <summary>
        /// Kariyer plan hepsini listeler
        /// </summary>
        /// <returns></returns>
        public List<CareerPlan> GetAllPlan()
        {
            List<CareerPlan> list = new List<CareerPlan>();

            SqlCommand cmd = new SqlCommand("SELECT ID,EgitimHakkinda,EgitimBaslamaTarihi,EgitimBitisTarihi,EgitimiVerenKurum,EgitimAdi,SubeID  FROM [InsanKaynaklari].[dbo].[tb_KariyerPlani]", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CareerPlan plan = new CareerPlan()
                {
                    ID = dr.GetInt32(0),
                    AboutEducations = dr.GetString(1),
                    StartDate = dr.GetDateTime(2),
                    EndDate = dr.GetDateTime(3),
                    EduCompanyID = dr.GetInt32(4),
                    EducationID = dr.GetInt32(5),
                    SectionID = dr.GetInt32(6)
                };
                list.Add(plan);
            }
            CloseConnection();
            return list;
        }

        /// <summary>
        /// Yeni bir kariyer plan oluşturur.
        /// </summary>
        /// <param name="create"></param>
        public void Create(CareerPlan create)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_KariyerPlani(EgitimHakkinda,EgitimBaslamaTarihi,EgitimBitisTarihi,EgitimiVerenKurum,EgitimAdi,SubeID) values(@EgitimHakkinda,@EgitimBaslamaTarihi,@EgitimBitisTarihi,@EgitimiVerenKurum,@EgitimAdi,@SubeID)", OpenConnection());

            cmd.Parameters.AddWithValue("@EgitimHakkinda", create.AboutEducations);
            cmd.Parameters.AddWithValue("@EgitimBaslamaTarihi", create.StartDate);
            cmd.Parameters.AddWithValue("@EgitimBitisTarihi", create.EndDate);
            cmd.Parameters.AddWithValue("@EgitimiVerenKurum", create.EduCompanyID);
            cmd.Parameters.AddWithValue("@EgitimAdi", create.EducationID);
            cmd.Parameters.AddWithValue("@SubeID", create.SectionID);

            cmd.ExecuteNonQuery();

            CloseConnection();

        }
     
        /// <summary>
        /// Geriye tk bir kariyer planı listeleme işlemi yapar.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public CareerPlan GetOneValue(CareerPlan c)
        {

            SqlCommand cmd = new SqlCommand("SELECT ID,EgitimHakkinda,EgitimBaslamaTarihi,EgitimBitisTarihi,EgitimiVerenKurum,EgitimAdi,SubeID  FROM [InsanKaynaklari].[dbo].[tb_KariyerPlani]", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();
            
              dr.Read();
                CareerPlan plan = new CareerPlan()
                {
                    ID = dr.GetInt32(0),
                    AboutEducations = dr.GetString(1),
                    StartDate = dr.GetDateTime(2),
                    EndDate = dr.GetDateTime(3),
                    EduCompanyID = dr.GetInt32(4),
                    EducationID = dr.GetInt32(5),
                    SectionID = dr.GetInt32(6)
                };
            CloseConnection();

            return plan;
        }
    }
}
