using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestEpisode
    {
        public ConquestEpisode()
        {
            ConquestEpisodeNames = new HashSet<ConquestEpisodeName>();
            ConquestEpisodeWarriors = new HashSet<ConquestEpisodeWarrior>();
            ConquestWarriorTransformationCompletedEpisodes = new HashSet<ConquestWarriorTransformation>();
            ConquestWarriorTransformationCurrentEpisodes = new HashSet<ConquestWarriorTransformation>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestEpisodeName> ConquestEpisodeNames { get; set; }
        public virtual ICollection<ConquestEpisodeWarrior> ConquestEpisodeWarriors { get; set; }
        public virtual ICollection<ConquestWarriorTransformation> ConquestWarriorTransformationCompletedEpisodes { get; set; }
        public virtual ICollection<ConquestWarriorTransformation> ConquestWarriorTransformationCurrentEpisodes { get; set; }
    }
}
