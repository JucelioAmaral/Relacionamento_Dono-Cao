using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEdesoft.Models
{
    public class Cao
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCao { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Raca { get; set; }

        public override string ToString() => $"{Nome},{Raca}".Trim();
    }
}
