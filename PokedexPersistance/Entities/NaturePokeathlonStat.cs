using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class NaturePokeathlonStat
    {
        public long NatureId { get; set; }
        public long PokeathlonStatId { get; set; }
        public long MaxChange { get; set; }

        public virtual Nature Nature { get; set; }
        public virtual PokeathlonStat PokeathlonStat { get; set; }
    }
}
