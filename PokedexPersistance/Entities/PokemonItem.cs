using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonItem
    {
        public long PokemonId { get; set; }
        public long VersionId { get; set; }
        public long ItemId { get; set; }
        public long Rarity { get; set; }

        public virtual Item Item { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual Version Version { get; set; }
    }
}
