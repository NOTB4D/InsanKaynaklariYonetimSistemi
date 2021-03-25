using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface ISupplyDetails
    {
        List<SupplyDetails> GetAllSupplyDetails();

        void Create(SupplyDetails supply);

        int Delete(int id);
    }
}
