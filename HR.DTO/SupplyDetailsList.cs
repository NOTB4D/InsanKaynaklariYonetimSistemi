using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class SupplyDetailsList //eksik malzeme listesi oluşuturur.
    {
        public int ID { get; set; }

        public int SectionID { get; set; }

        public int SupplyID { get; set; }

        
        public int RequestID { get; set; }
    }
}
