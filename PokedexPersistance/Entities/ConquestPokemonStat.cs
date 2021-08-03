using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestPokemonStat
    {
        public long PokemonSpeciesId { get; set; }
        public long ConquestStatId { get; set; }
        public long BaseStat { get; set; }

        public virtual ConquestStat ConquestStat { get; set; }
        public virtual PokemonSpecy PokemonSpecies { get; set; }
    }
}
