using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveMetum
    {
        public long MoveId { get; set; }
        public long MetaCategoryId { get; set; }
        public long MetaAilmentId { get; set; }
        public long? MinHits { get; set; }
        public long? MaxHits { get; set; }
        public long? MinTurns { get; set; }
        public long? MaxTurns { get; set; }
        public long Drain { get; set; }
        public long Healing { get; set; }
        public long CritRate { get; set; }
        public long AilmentChance { get; set; }
        public long FlinchChance { get; set; }
        public long StatChance { get; set; }

        public virtual MoveMetaAilment MetaAilment { get; set; }
        public virtual MoveMetaCategory MetaCategory { get; set; }
        public virtual Move Move { get; set; }
    }
}
