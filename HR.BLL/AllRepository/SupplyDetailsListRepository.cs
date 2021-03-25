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
    public class SupplyDetailsListRepository : Connector, ISupplyDetailsList
    {

        /// <summary>
        /// Malzeme eksik listesi bilgilerini listeler.
        /// </summary>
        /// <returns></returns>
        public List<SupplyDetailsList> GetAllDetails()
        {
            List<SupplyDetailsList> list = new List<SupplyDetailsList>();
            SqlCommand cmd = new SqlCommand("SELECT  [ID],[SubeID],[MalzemeID],[IstekID] FROM [InsanKaynaklari].[dbo].[tb_MalzemeEksikListesi]", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SupplyDetailsList s = new SupplyDetailsList()
                {
                    ID = dr.GetInt32(0),
                    SectionID = dr.GetInt32(1),
                    SupplyID = dr.GetInt32(2),
                    RequestID = dr.GetInt32(3)
                };
                list.Add(s);
            }
            CloseConnection();

            return list;
        }
        /// <summary>
        /// Malzeme eksik listesi oluşturur.
        /// </summary>
        /// <param name="supply"></param>
        public void Create(SupplyDetailsList supply)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_MalzemeEksikListesi(SubeID,MalzemeID,IstekID) values(@SubeID,@MalzemeID,@IstekID)", OpenConnection());

            cmd.Parameters.AddWithValue("@SubeID", supply.SectionID);
            cmd.Parameters.AddWithValue("@MalzemeID", supply.SupplyID);
            cmd.Parameters.AddWithValue("@IstekID", supply.RequestID);

            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// Malzeme eksik listesi silme işlemi yapar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from tb_MalzemeEksikListesi Where ID=@id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);

            int effectedRow = cmd.ExecuteNonQuery();
            CloseConnection();

            return effectedRow;
        }
    }
}
