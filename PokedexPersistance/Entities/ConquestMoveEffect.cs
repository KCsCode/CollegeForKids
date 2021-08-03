using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveEffect
    {
        public ConquestMoveEffect()
        {
            ConquestMoveData = new HashSet<ConquestMoveDatum>();
            ConquestMoveEffectProses = new HashSet<ConquestMoveEffectProse>();
        }

        public long Id { get; set; }

        public virtual ICollection<ConquestMoveDatum> ConquestMoveData { get; set; }
        public virtual ICollection<ConquestMoveEffectProse> ConquestMoveEffectProses { get; set; }
    }
}
