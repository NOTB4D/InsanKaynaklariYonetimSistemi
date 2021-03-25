using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface IStaff
    {
        List<Staff> GetAllStaff();

        void Create(Staff staff);

        int Delete(int id);

        Staff GetOneValue(Staff s);

        void Update(Staff s);
    }
}
