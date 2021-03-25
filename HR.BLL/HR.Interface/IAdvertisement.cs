using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface IAdvertisement
    {
        List<Advertisement> List();

        void Create(Advertisement adv);
    }
}
