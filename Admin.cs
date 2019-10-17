using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FourthGear.Data
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId{ get; set; }
        public int Name{ get; set; }
        public string Type { get; set; }

        //foreign key connects DeptHead table

        public int DeptHId { get; set; }
        [ForeignKey("DeptHId")]
        public DeptHead Dept { get; set; }

        //foreign key connects SLT table

        public int  SLTId { get; set; }
        [ForeignKey("SLTId")]
        public SLT MyTeam { get; set; }



    }
}
