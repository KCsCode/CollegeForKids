using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonStat
    {
        public long PokemonId { get; set; }
        public long StatId { get; set; }
        public long BaseStat { get; set; }
        public long Effort { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual Stat Stat { get; set; }
    }
}
