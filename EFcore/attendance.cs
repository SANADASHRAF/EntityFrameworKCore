using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    internal class attendance
    {
        [Key]
        public int employeeid { get; set; }
        public DateTime date { get; set; }
        public virtual ICollection<employee> ?employees { get; set; }
    }
}

