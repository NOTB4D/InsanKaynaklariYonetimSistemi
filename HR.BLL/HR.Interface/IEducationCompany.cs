using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface IEducationCompany
    {
        List<EducationCompany> List();

        void Create(EducationCompany create);

       // int Delete(int id);

        void Update(EducationCompany update);

        EducationCompany GetOneValue(EducationCompany ed);
    }
}
