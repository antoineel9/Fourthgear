using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FourthGear.Data
{
    public class DeptHead
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DHId { get; set; }
        [ForeignKey("DHId")]

        public DeptHead Dept { get; set; }
    }
}
