using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class SuperContestEffect
    {
        public SuperContestEffect()
        {
            Moves = new HashSet<Move>();
            SuperContestEffectProses = new HashSet<SuperContestEffectProse>();
        }

        public long Id { get; set; }
        public long Appeal { get; set; }

        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<SuperContestEffectProse> SuperContestEffectProses { get; set; }
    }
}
