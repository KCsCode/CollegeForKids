using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestPokemonMove
    {
        public long PokemonSpeciesId { get; set; }
        public long MoveId { get; set; }

        public virtual Move Move { get; set; }
        public virtual PokemonSpecy PokemonSpecies { get; set; }
    }
}
