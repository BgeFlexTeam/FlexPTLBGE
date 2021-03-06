using System;
using Dapper.Contrib.Extensions;

namespace PTL.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string SerialNumber { get; set; }
        public int PartID { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsComplete { get; set; }
        public int StationID { get; set; }
    }
}
