using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorRank
    {
        public ConquestWarriorRank()
        {
            ConquestMaxLinks = new HashSet<ConquestMaxLink>();
            ConquestWarriorRankStatMaps = new HashSet<ConquestWarriorRankStatMap>();
        }

        public long Id { get; set; }
        public long WarriorId { get; set; }
        public long Rank { get; set; }
        public long SkillId { get; set; }

        public virtual ConquestWarriorSkill Skill { get; set; }
        public virtual ConquestWarrior Warrior { get; set; }
        public virtual ConquestWarriorTransformation ConquestWarriorTransformation { get; set; }
        public virtual ICollection<ConquestMaxLink> ConquestMaxLinks { get; set; }
        public virtual ICollection<ConquestWarriorRankStatMap> ConquestWarriorRankStatMaps { get; set; }
    }
}
