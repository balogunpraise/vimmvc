using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Duration { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
