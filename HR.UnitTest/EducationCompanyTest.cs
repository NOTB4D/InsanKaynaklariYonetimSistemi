using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HR.BLL.AllRepository;
using HR.DTO;

namespace HR.UnitTest
{
    [TestClass]
    public class EducationCompanyTest
    {
        [TestMethod]
        public void EducationTest()
        {
            EducationCompanyRepository company = new EducationCompanyRepository();
            EducationCompany c = new EducationCompany()
            {
                ID = 8,
                Name = "Test2"
            };
            company.Create(c);
        }

        [TestMethod]
        public void EducationTestList()
        {
            EducationCompanyRepository company = new EducationCompanyRepository();

            Assert.IsNotNull(company.List(), "Başarılı");
        }
    }
}
