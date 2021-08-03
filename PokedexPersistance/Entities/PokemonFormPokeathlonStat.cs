using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonFormPokeathlonStat
    {
        public long PokemonFormId { get; set; }
        public long PokeathlonStatId { get; set; }
        public long MinimumStat { get; set; }
        public long BaseStat { get; set; }
        public long MaximumStat { get; set; }

        public virtual PokeathlonStat PokeathlonStat { get; set; }
        public virtual PokemonForm PokemonForm { get; set; }
    }
}
