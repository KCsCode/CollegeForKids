using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorSkill
    {
        public ConquestWarriorSkill()
        {
            ConquestWarriorRanks = new HashSet<ConquestWarriorRank>();
            ConquestWarriorSkillNames = new HashSet<ConquestWarriorSkillName>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestWarriorRank> ConquestWarriorRanks { get; set; }
        public virtual ICollection<ConquestWarriorSkillName> ConquestWarriorSkillNames { get; set; }
    }
}
