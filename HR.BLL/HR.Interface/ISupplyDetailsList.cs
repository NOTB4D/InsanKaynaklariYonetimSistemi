using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface ISupplyDetailsList
    {
        List<SupplyDetailsList> GetAllDetails();

        void Create(SupplyDetailsList supply);

        int Delete(int id);
    }
}
