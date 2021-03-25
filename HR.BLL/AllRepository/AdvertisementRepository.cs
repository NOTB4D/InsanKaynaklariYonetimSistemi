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
    public class AdvertisementRepository : Connector, IAdvertisement
    {
        public List<Advertisement> List()
        {
            List<Advertisement> list = new List<Advertisement>();
            SqlCommand cmd = new SqlCommand("Select ID,IlanAdi from tb_Ilan", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Advertisement()
                {
                    ID = dr.GetInt32(0),
                    Name = dr.GetValue(1).ToString()
                });
            }
            CloseConnection();

            return list;
        }


        public void Create(Advertisement adv)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_Ilan(IlanAdi,AlinacakPersonelSayisi,Aciklama,SirketAdi,SubeAdi) values(@IlanAdi,@AlinacakPersonelSayisi,@Aciklama,@SirketAdi,@SubeAdi)",OpenConnection());

            cmd.Parameters.AddWithValue("@IlanAdi", adv.Name);
            cmd.Parameters.AddWithValue("@AlinacakPersonelSayisi", adv.NumberOfPersonel);
            cmd.Parameters.AddWithValue("@Aciklama", adv.Description);
            cmd.Parameters.AddWithValue("@SirketAdi", adv.CompanyID);
            cmd.Parameters.AddWithValue("@SubeAdi", adv.SectionID);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
