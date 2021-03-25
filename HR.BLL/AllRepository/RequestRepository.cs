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
    public class RequestRepository : Connector , IRequest
    {
        /// <summary>
        /// Bütün istek bilgilerini listeler
        /// </summary>
        /// <returns></returns>
        public List<Request> GetAllRequest()
        {
            List<Request> list = new List<Request>();
            SqlCommand cmd = new SqlCommand("Select ID,IstekTipi from tb_IstekTipi",OpenConnection());

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Request r = new Request() { 
                 ID=dr.GetInt32(0),
                  RequestName=dr.GetString(1)
                };
                list.Add(r);
            }
            CloseConnection();

            return list;
        }
        /// <summary>
        /// Yeni bir istek tipi bilgisini oluşturur.
        /// </summary>
        /// <param name="request"></param>
        public void Create(Request request)
        {
            SqlCommand cmd = new SqlCommand("Insert tb_IstekTipi(IstekTipi) values(@IstekTipi)",OpenConnection());
            cmd.Parameters.AddWithValue("@IstekTipi",request.RequestName);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
        /// <summary>
        /// ID'ye göre istek tip bilgisini silme işlemini yapar.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from tb_IstekTipi where ID=@id",OpenConnection());
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
