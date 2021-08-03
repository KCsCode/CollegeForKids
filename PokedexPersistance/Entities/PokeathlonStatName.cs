using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokeathlonStatName
    {
        public long PokeathlonStatId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual PokeathlonStat PokeathlonStat { get; set; }
    }
}
