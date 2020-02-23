using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCharacter.Models
{
    public class Power
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PowerId { get; set; }
        public string Spell { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }

        public ICollection<Archon> Archon { get; set; }
    }
}
