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
    public class SupplyDetailsRepository : Connector, ISupplyDetails
    {
        /// <summary>
        /// Malzeme detay listesi bilgilerini listeler.
        /// </summary>
        /// <returns></returns>
        public List<SupplyDetails> GetAllSupplyDetails()
        {
            List<SupplyDetails> list = new List<SupplyDetails>();

            SqlCommand cmd = new SqlCommand("SELECT [ID],[Adet],[MalzemeID] ,[SubeID],[BirimID] FROM [InsanKaynaklari].[dbo].[tb_MalzemeDetay]", OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SupplyDetails sd = new SupplyDetails()
                {
                    ID = dr.GetInt32(0),
                    Amount = dr.GetInt32(1),
                    SupplyID = dr.GetInt32(2),
                    SectionID = dr.GetInt32(3),
                    DepartmentID = dr.GetInt32(4)
                };
                list.Add(sd);
            }
            CloseConnection();

            return list;
        }
        /// <summary>
        /// Malzeme detay bilgisi oluşturma işlemi yapar.
        /// </summary>
        /// <param name="supply"></param>
        public void Create(SupplyDetails supply)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_MalzemeDetay(Adet,MalzemeID,SubeID,BirimID) values(@Adet,@MalzemeID,@SubeID,@BirimID)",OpenConnection());

            cmd.Parameters.AddWithValue("@Adet",supply.Amount);
            cmd.Parameters.AddWithValue("@MalzemeID",supply.SupplyID);
            cmd.Parameters.AddWithValue("@SubeID",supply.SectionID);
            cmd.Parameters.AddWithValue("@BirimID",supply.DepartmentID);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
        /// <summary>
        /// ID parametersine göre malzeme detay listesi bilgilerini siler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from tb_MalzemeDetay where ID=@id",OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);

            int effectedRow = cmd.ExecuteNonQuery();

            CloseConnection();
            return effectedRow;
        }
    }
}
