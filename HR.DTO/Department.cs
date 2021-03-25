using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string UnitManager { get; set; }

        public string Director { get; set; }

        public int SectionName { get; set; }
        public string SName { get; set; }
        public int SubeID { get; set; }
    }
}
