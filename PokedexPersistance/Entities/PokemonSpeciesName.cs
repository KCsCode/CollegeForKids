using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonSpeciesName
    {
        public long PokemonSpeciesId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Genus { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual PokemonSpecy PokemonSpecies { get; set; }
    }
}
