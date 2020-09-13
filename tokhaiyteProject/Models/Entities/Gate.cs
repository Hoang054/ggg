using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tokhaiyteProject.Models.Entities
{
    public class Gate
    {
        public int id { get; set; }
        public string GateName { get; set; }
        public int IsPublished { get; set; }
        public int IsDeleted { get; set; }
    }
}
