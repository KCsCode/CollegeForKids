using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorStat
    {
        public ConquestWarriorStat()
        {
            ConquestWarriorRankStatMaps = new HashSet<ConquestWarriorRankStatMap>();
            ConquestWarriorStatNames = new HashSet<ConquestWarriorStatName>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestWarriorRankStatMap> ConquestWarriorRankStatMaps { get; set; }
        public virtual ICollection<ConquestWarriorStatName> ConquestWarriorStatNames { get; set; }
    }
}
