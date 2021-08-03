using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveEffect
    {
        public MoveEffect()
        {
            MoveChangelogs = new HashSet<MoveChangelog>();
            MoveEffectChangelogs = new HashSet<MoveEffectChangelog>();
            MoveEffectProses = new HashSet<MoveEffectProse>();
            Moves = new HashSet<Move>();
        }

        public long Id { get; set; }

        public virtual ICollection<MoveChangelog> MoveChangelogs { get; set; }
        public virtual ICollection<MoveEffectChangelog> MoveEffectChangelogs { get; set; }
        public virtual ICollection<MoveEffectProse> MoveEffectProses { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
    }
}
