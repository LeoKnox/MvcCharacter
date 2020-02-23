using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public enum CharacterClass
    {
        Fighter, Thief, Wizard
    }
    public class Archon
    {
        public int ArchonID {get; set; }
        public int CharacterID { get; set; }
        public int PowerID { get; set; }
        public CharacterClass? CharacterClass { get; set; }

        public Character Character { get; set; }
        public Power Power { get; set; }
    }
}
