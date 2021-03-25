using HR.BLL.AllRepository;
using HR.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.UnitTest
{
    [TestClass]
    public class SectionRepositoryTest
    {
        [TestMethod]
        public void Create()
        {
            SectionRepository section = new SectionRepository();

            Section s = new Section()
            {
                ID = 1233,
                Addres = "test",
                Email = "test@hr.com",
                Fax = "3211234554",
                PhoneNumber = "3211234554",
                SectionName = "asda"
            };
            section.Create(s);   
        }
        [TestMethod]
        public void SectionList()
        {
            SectionRepository section = new SectionRepository();
            section.GetAllSection();

        }

    }
}
