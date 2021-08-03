using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonGameIndex
    {
        public long PokemonId { get; set; }
        public long VersionId { get; set; }
        public long GameIndex { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual Version Version { get; set; }
    }
}
