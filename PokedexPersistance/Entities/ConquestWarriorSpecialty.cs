using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorSpecialty
    {
        public long WarriorId { get; set; }
        public long TypeId { get; set; }
        public long Slot { get; set; }

        public virtual Type Type { get; set; }
        public virtual ConquestWarrior Warrior { get; set; }
    }
}
