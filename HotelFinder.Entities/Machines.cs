using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mac.Entities
{
    public class Machines
    {
        
        public int ID { get; set; }
       
        public int ConnectionID { get; set; }
        public string? Module { get; set; }
        public string? Name { get; set; }
        public string? ProductionAddress { get; set; }
        public string?  ProductionValue { get; set; }
        public string? CurrentProductionaddress { get; set; }

        public ICollection<PLCQualityCriterionDatas>? QualityDatas { get; set; }

    }
}
