using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    //data anotation
    [Table("employee")]
    internal class employee
    {
        public int id { get; set; }
        public string? name { get; set; }


        //detect by convension
        [Column("Departmenid")]
        public int? departmenid { get; set; }
        //navigation prooerity
        public bool deleted { get; set; }
        public virtual department? department { get; set; }

        public virtual ICollection<attendance> attendances { get; set; }

    }
}

