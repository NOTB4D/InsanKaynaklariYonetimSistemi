using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class CareerPlan
    {
        public int ID { get; set; }

        public int EducationID { get; set; }

        public int SectionID { get; set; }

        public int EduCompanyID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string AboutEducations { get; set; }
    }
}
