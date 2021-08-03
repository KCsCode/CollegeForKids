using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestEpisodeName
    {
        public long EpisodeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ConquestEpisode Episode { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
