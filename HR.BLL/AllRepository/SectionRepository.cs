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
    public class SectionRepository : Connector, ISection
    {
        Section s;
        /// <summary>
        /// Şubelerin hepsini listeler.
        /// </summary>
        /// <returns></returns>
        public List<Section> GetAllSection()
        {
            List<Section> list = new List<Section>();

            SqlCommand cmd = new SqlCommand("Select ID,SubeAdi from tb_Subeler", OpenConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Section s = new Section()
                {
                    ID = dr.GetInt32(0),
                    SectionName = dr.GetString(1)
                };
                list.Add(s);
            }
            CloseConnection();

            return list;
        }

        /// <summary>
        /// Yeni bir şube bilgisi ekler.
        /// </summary>
        /// <param name="insert"></param>
        public void Create(Section insert)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_Subeler(SubeAdi,Telefon,Adres,Email,Fax) values(@SubeAdi,@Telefon,@Adres,@Email,@Fax)", OpenConnection());

            cmd.Parameters.AddWithValue("@SubeAdi", insert.SectionName);
            cmd.Parameters.AddWithValue("@Telefon", insert.PhoneNumber);
            cmd.Parameters.AddWithValue("@Adres", insert.Addres);
            cmd.Parameters.AddWithValue("@Email", insert.Email);
            cmd.Parameters.AddWithValue("@Fax", insert.Fax);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// Update bilgisi için gerekli olan geriye tek bir veriyi taşır.
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        public Section GetOneValue(Section section)
        {
            SqlCommand cmd = new SqlCommand("Select ID,SubeAdi,Telefon,Email,Adres,Fax from tb_Subeler where ID=@id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", section.ID);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            
                 s = new Section()
                {
                    ID = dr.GetInt32(0),
                    SectionName = dr.GetString(1),
                    PhoneNumber = dr.GetString(2),
                    Email = dr.GetString(3),
                    Addres = dr.GetString(4),
                    Fax = dr.GetString(5)
                };
            
            CloseConnection();

            return s;
        }

        /// <summary>
        /// Şube bilgilerini güncellemek için kullanılır.
        /// </summary>
        /// <param name="section"></param>
        public void Update(Section section)
        {
            SqlCommand cmd = new SqlCommand("Update tb_Subeler set Telefon=@tel,Email=@mail,Adres=@adres,Fax=@fax where ID=@id",OpenConnection());
            cmd.Parameters.AddWithValue("@tel", section.PhoneNumber);
            cmd.Parameters.AddWithValue("@mail", section.Email);
            cmd.Parameters.AddWithValue("@adres", section.Addres);
            cmd.Parameters.AddWithValue("@fax", section.Fax);
            cmd.Parameters.AddWithValue("@id", section.SectionName);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }


        public List<Section> list()
        {
            List<Section> list = new List<Section>();
            SqlCommand cmd = new SqlCommand("SELECT  tb_Subeler.SubeAdi, tb_Kadro.SubeID, tb_Kadro.PersonelSayisi FROM   tb_Kadro INNER JOIN tb_Subeler ON tb_Kadro.SubeID = tb_Subeler.ID",OpenConnection());
            SqlDataReader dr=cmd.ExecuteReader();

            while (dr.Read())
            {
                Section s = new Section() { 
                  SectionName=dr.GetString(0),
                   ID=dr.GetInt32(1),
                    NumberofPerson=dr.GetInt32(2),
                   
                };
                list.Add(s);
            }
            CloseConnection();
            return list;
        }
    }
}
