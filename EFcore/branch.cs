using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    internal class branch
    {
        public int id { get; set; }
        public string? name { get; set; }
        
        public virtual ICollection<department> department { get; set; }
    }
}

