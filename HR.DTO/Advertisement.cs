using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Advertisement
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int NumberOfPersonel { get; set; }

        public string Description { get; set; }

        public int SectionID { get; set; }
        public int CompanyID { get; set; }
    }
}
