using HR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.BLL.HR.Interface
{
    public interface ISection
    {
        List<Section> GetAllSection();

        void Create(Section insert);

        Section GetOneValue(Section section);

        void Update(Section section);

        /// <summary>
        /// Personel sayısı olan subeler buraya listelenir.
        /// </summary>
        /// <returns></returns>
        List<Section> list();
    }
}
