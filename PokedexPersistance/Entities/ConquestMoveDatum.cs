using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveDatum
    {
        public long MoveId { get; set; }
        public long? Power { get; set; }
        public long? Accuracy { get; set; }
        public long? EffectChance { get; set; }
        public long EffectId { get; set; }
        public long RangeId { get; set; }
        public long? DisplacementId { get; set; }

        public virtual ConquestMoveDisplacement Displacement { get; set; }
        public virtual ConquestMoveEffect Effect { get; set; }
        public virtual Move Move { get; set; }
        public virtual ConquestMoveRange Range { get; set; }
    }
}
