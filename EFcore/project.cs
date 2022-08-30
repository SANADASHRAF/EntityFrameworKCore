using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    internal class project
    {
        public int id { get; set; } 
        public string? Name { get; set; }
        
        
        //detect by convension
        public int? departmentid { get; set; }
        //navigation prooerity
        public virtual department? department { get; set; }
    }
}
