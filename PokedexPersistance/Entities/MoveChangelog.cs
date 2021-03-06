using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveChangelog
    {
        public long MoveId { get; set; }
        public long ChangedInVersionGroupId { get; set; }
        public long? TypeId { get; set; }
        public long? Power { get; set; }
        public long? Pp { get; set; }
        public long? Accuracy { get; set; }
        public long? Priority { get; set; }
        public long? TargetId { get; set; }
        public long? EffectId { get; set; }
        public long? EffectChance { get; set; }

        public virtual VersionGroup ChangedInVersionGroup { get; set; }
        public virtual MoveEffect Effect { get; set; }
        public virtual Move Move { get; set; }
        public virtual MoveTarget Target { get; set; }
        public virtual Type Type { get; set; }
    }
}
