using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestEpisodeWarrior
    {
        public long EpisodeId { get; set; }
        public long WarriorId { get; set; }

        public virtual ConquestEpisode Episode { get; set; }
        public virtual ConquestWarrior Warrior { get; set; }
    }
}
