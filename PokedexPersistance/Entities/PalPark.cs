using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PalPark
    {
        public long SpeciesId { get; set; }
        public long AreaId { get; set; }
        public long BaseScore { get; set; }
        public long Rate { get; set; }

        public virtual PalParkArea Area { get; set; }
        public virtual PokemonSpecy Species { get; set; }
    }
}
