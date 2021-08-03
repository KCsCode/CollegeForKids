using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonSpeciesFlavorText
    {
        public long SpeciesId { get; set; }
        public long VersionId { get; set; }
        public long LanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Language Language { get; set; }
        public virtual PokemonSpecy Species { get; set; }
        public virtual Version Version { get; set; }
    }
}
