using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface IRequest
    {
        List<Request> GetAllRequest();

        void Create(Request request);

        void Delete(int id);
    }
}
