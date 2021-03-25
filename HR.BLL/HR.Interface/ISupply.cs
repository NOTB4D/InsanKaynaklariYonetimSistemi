using HR.DTO;
using System.Collections.Generic;
namespace HR.BLL.HR.Interface
{
    public interface ISupply
    {
        List<Supply> GetAllSupply();

        void Create(Supply supply);

        int Delete(int id);
    }
}
