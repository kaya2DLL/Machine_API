using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mac.Entities
{
    public class PLCQualityCriterionDatas
    {
        [Key]
        public int OID { get; set; }
        public int MachineID { get; set; }
        public int DataExplainID { get; set; }
        public double DataValue { get; set; }
        public DateTime Times { get; set; }
        public double DataDifferenceValue { get; set; }

        public Machines Machine { get; set; }
    }
}
