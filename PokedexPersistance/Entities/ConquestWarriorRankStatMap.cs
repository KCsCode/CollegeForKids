using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorRankStatMap
    {
        public long WarriorRankId { get; set; }
        public long WarriorStatId { get; set; }
        public long BaseStat { get; set; }

        public virtual ConquestWarriorRank WarriorRank { get; set; }
        public virtual ConquestWarriorStat WarriorStat { get; set; }
    }
}
