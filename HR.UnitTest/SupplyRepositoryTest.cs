using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HR.BLL.AllRepository;
using HR.DTO;

namespace HR.UnitTest
{
    [TestClass]
    public class SupplyRepositoryTest
    {
        [TestMethod]
        public void Create()
        {
            SupplyRepository supply = new SupplyRepository();
            Supply s = new Supply() { 
             ID=2,
              SupplyName="Microsoft Mouse"
            };
            supply.Create(s);
        }

        [TestMethod]
        public void SupplyList()
        {
            SupplyRepository supply = new SupplyRepository();
            supply.GetAllSupply();
        }
    }
}
