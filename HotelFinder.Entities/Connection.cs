using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HotelFinder.Entities
{
    public class Connection
    {
        [Key]
        public int ID { get; set; }
        
        [StringLength(10)]
        public string? ProductName { get; set; }
        
        public char ProductCode { get; set; }

        [StringLength(10)]
        public string? IpAddress { get; set; }
        
        public int MachineNumber { get; set; }
        
        public DateTime ServiceCheck { get; set; }
        
        public bool ServiceCheckControl { get; set; }
        
        public char PLCType { get; set; }
        
        public char Port { get; set; }





    }
}