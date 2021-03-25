using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface IDepartment
    {
        List<Department> GetAllDepartment();

        void Create(Department insert);

        int Delete(int birimID,int SubeID);

        Department GetOneValue(Department dep);

        void Update(Department update);
    }
}
