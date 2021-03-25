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
    public class StaffRepositoryTest
    {
        [TestMethod]
        public void StaffList()
        {
            StaffRepository staff = new StaffRepository();
            Assert.IsNotNull(staff.GetAllStaff());
        }

        [TestMethod]
        public void Create()
        {
            StaffRepository staff = new StaffRepository();
            Staff s = new Staff()
            {
                ID = 1,
                SectionID = 1,
                StaffCount = 33
            };
            staff.Create(s);
        }
    }
}
