using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEdesoft.Models
{
    public class Relacao_Dono_Cao
    {
        [Key]
        public int IdDono { get; set; }
        [Key]
        public int IdCao { get; set; }
    }
}
