using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonEggGroup
    {
        public long SpeciesId { get; set; }
        public long EggGroupId { get; set; }

        public virtual EggGroup EggGroup { get; set; }
        public virtual PokemonSpecy Species { get; set; }
    }
}
