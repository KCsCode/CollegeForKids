using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ContestEffect
    {
        public ContestEffect()
        {
            ContestEffectProses = new HashSet<ContestEffectProse>();
            Moves = new HashSet<Move>();
        }

        public long Id { get; set; }
        public long Appeal { get; set; }
        public long Jam { get; set; }

        public virtual ICollection<ContestEffectProse> ContestEffectProses { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
    }
}
