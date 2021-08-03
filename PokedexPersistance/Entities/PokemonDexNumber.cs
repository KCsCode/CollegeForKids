using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonDexNumber
    {
        public long SpeciesId { get; set; }
        public long PokedexId { get; set; }
        public long PokedexNumber { get; set; }

        public virtual Pokedex Pokedex { get; set; }
        public virtual PokemonSpecy Species { get; set; }
    }
}
