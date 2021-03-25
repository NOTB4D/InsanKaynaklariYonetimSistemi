using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface IEducation
    {
        List<Education> List();

        void Create(Education create);

        //int Delete(int id);

        Education GetOneValue(Education edu);

        void Update(Education update);
    }
}
