using HR.BLL.HR.Interface;
using HR.DAL;
using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HR.BLL.AllRepository
{
    public class SupplyRepository : Connector, ISupply
    {
        /// <summary>
        /// Malzeme isimlerini listeler.
        /// </summary>
        /// <returns></returns>
        public List<Supply> GetAllSupply()
        {
            List<Supply> list = new List<Supply>();

            SqlCommand cmd = new SqlCommand("Select ID,MalzemeAdi from tb_Malzeme", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Supply s = new Supply()
                {
                    ID = dr.GetInt32(0),
                    SupplyName = dr.GetString(1)
                };
                list.Add(s);
            }
            CloseConnection();
            return list;
        }
        /// <summary>
        /// Yeni bir malzeme adı bilgisi ekleme işlemini yapar.
        /// </summary>
        /// <param name="supply"></param>
        public void Create(Supply supply)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_Malzeme(MalzemeAdi) values(@MalzemeAdi)", OpenConnection());
            cmd.Parameters.AddWithValue("@MalzemeAdi", supply.SupplyName);

            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// ID parametresine göre MalzemeAdı bilgisini siler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from tb_Malzeme Where ID=@id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);

            int effectedRow = cmd.ExecuteNonQuery();

            CloseConnection();
            return effectedRow;
        }
    }
}
