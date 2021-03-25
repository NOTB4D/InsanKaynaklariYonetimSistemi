using HR.BLL.HR.Interface;
using HR.DAL;
using HR.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HR.BLL
{
    public class DepartmentRepository : Connector, IDepartment
    {
        /// <summary>
        /// Bütün birimlerin listesini geritirir.
        /// </summary>
        /// <returns></returns>
        public List<Department> GetAllDepartment()
        {
            List<Department> list = new List<Department>();

            SqlCommand cmd = new SqlCommand("Select ID,BirimAdi from tb_Birim", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Department d = new Department()
                {
                    ID = dr.GetInt32(0),
                    DepartmentName = dr.GetString(1)
                };
                list.Add(d);
            }
            CloseConnection();

            return list;

        }

        /// <summary>
        /// Yeni bir birim oluşturma işlemini yapar.
        /// </summary>
        /// <param name="insert"></param>
        public void Create(Department insert)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_Birim(BirimAdi,YoneticiAdi,BirimMuduru,SubeID) values(@BirimAdi,@YoneticiAdi,@BirimMuduru,@SubeID)", OpenConnection());

            cmd.Parameters.AddWithValue("@BirimAdi", insert.DepartmentName);
            cmd.Parameters.AddWithValue("@YoneticiAdi", insert.Director);
            cmd.Parameters.AddWithValue("@BirimMuduru", insert.UnitManager);
            cmd.Parameters.AddWithValue("@SubeID", insert.SectionName);

            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// BiriimID ve subeID parametresine göre birim siler.
        /// </summary>
        /// <param name="birimID"></param>
        /// <param name="subeID"></param>
        /// <returns></returns>
        public int Delete(int birimID, int subeID)
        {
            SqlCommand cmd = new SqlCommand("Delete from tb_Birim where SubeID=@subeId and ID=@birimId", OpenConnection());
            cmd.Parameters.AddWithValue("@subeId", birimID);
            cmd.Parameters.AddWithValue("@birimId", subeID);
            int effectedRow = cmd.ExecuteNonQuery();

            CloseConnection();
            return effectedRow;
        }
        /// <summary>
        ///Update işlemine göre sorgu sırasıda geriye tek bir birim bilgisi döndürür.
        /// </summary>
        /// <param name="dep"></param>
        /// <returns></returns> 
        Department d;
        public Department GetOneValue(Department dep)
        {

            SqlCommand cmd = new SqlCommand("Select B.ID,B.BirimAdi,B.YoneticiAdi,B.BirimMuduru,S.SubeAdi,S.ID from tb_Subeler s join tb_Birim b on s.ID=b.SubeID WHERE S.ID=@id ", OpenConnection());
            cmd.Parameters.AddWithValue("@id", dep.SectionName);
           
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                d= new Department()
                {
                    ID = dr.GetInt32(0),
                    DepartmentName = dr.GetString(1),
                    Director = dr.GetString(2),
                    UnitManager = dr.GetString(3),
                    SName = dr.GetString(4),
                    SubeID = dr.GetInt32(5)
                };
            }

            CloseConnection();

            return d;
        }
        /// <summary>
        ///Birim bilgilerini günceller.
        /// </summary>
        /// <param name="update"></param>
        public void Update(Department update)
        {
            SqlCommand cmd = new SqlCommand("Update tb_Birim set BirimAdi=@birimAdi,YoneticiAdi=@yoneticiAdi,BirimMuduru=@birimMuduru  WHERE SubeID=@id",OpenConnection());

            cmd.Parameters.AddWithValue("@birimadi", update.DepartmentName);
            cmd.Parameters.AddWithValue("@yoneticiAdi", update.Director);
            cmd.Parameters.AddWithValue("@birimMuduru", update.UnitManager);
            cmd.Parameters.AddWithValue("@id", update.SectionName);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
