using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonType
    {
        public long PokemonId { get; set; }
        public long TypeId { get; set; }
        public long Slot { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual Type Type { get; set; }
    }
}
