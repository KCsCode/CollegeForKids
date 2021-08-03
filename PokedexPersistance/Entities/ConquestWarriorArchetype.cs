using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorArchetype
    {
        public ConquestWarriorArchetype()
        {
            ConquestWarriors = new HashSet<ConquestWarrior>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestWarrior> ConquestWarriors { get; set; }
    }
}
