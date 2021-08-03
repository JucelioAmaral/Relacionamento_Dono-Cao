using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEdesoft.Models
{
    public class Dono
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDono { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }

        public override string ToString() => $"{Nome}".Trim();
    }
}
