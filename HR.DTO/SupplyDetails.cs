using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class SupplyDetails
    {
        public int ID { get; set; }
        public int Amount { get; set; }

        public int SupplyID { get; set; }

        public int SectionID { get; set; }

        public int DepartmentID { get; set; }
    }
}
