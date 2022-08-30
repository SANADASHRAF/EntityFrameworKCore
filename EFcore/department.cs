using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    internal class department
    {
        public int id { get; set; }
        public string? name { get; set; }


        // detect by convension [forign key]
        public int branchid { get; set; }
        //navigation propirity
        public virtual branch branch { get; set; }
        

        public virtual ICollection<employee> employees { get; set; }
        public virtual ICollection<project> projects { get; set; }

    }
}
