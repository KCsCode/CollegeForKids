using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarrior
    {
        public ConquestWarrior()
        {
            ConquestEpisodeWarriors = new HashSet<ConquestEpisodeWarrior>();
            ConquestTransformationWarriors = new HashSet<ConquestTransformationWarrior>();
            ConquestWarriorNames = new HashSet<ConquestWarriorName>();
            ConquestWarriorRanks = new HashSet<ConquestWarriorRank>();
            ConquestWarriorSpecialties = new HashSet<ConquestWarriorSpecialty>();
            ConquestWarriorTransformations = new HashSet<ConquestWarriorTransformation>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenderId { get; set; }
        public long? ArchetypeId { get; set; }

        public virtual ConquestWarriorArchetype Archetype { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<ConquestEpisodeWarrior> ConquestEpisodeWarriors { get; set; }
        public virtual ICollection<ConquestTransformationWarrior> ConquestTransformationWarriors { get; set; }
        public virtual ICollection<ConquestWarriorName> ConquestWarriorNames { get; set; }
        public virtual ICollection<ConquestWarriorRank> ConquestWarriorRanks { get; set; }
        public virtual ICollection<ConquestWarriorSpecialty> ConquestWarriorSpecialties { get; set; }
        public virtual ICollection<ConquestWarriorTransformation> ConquestWarriorTransformations { get; set; }
    }
}
