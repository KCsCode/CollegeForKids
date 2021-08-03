using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonSpeciesFlavorSummary
    {
        public long PokemonSpeciesId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FlavorSummary { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual PokemonSpecy PokemonSpecies { get; set; }
    }
}
