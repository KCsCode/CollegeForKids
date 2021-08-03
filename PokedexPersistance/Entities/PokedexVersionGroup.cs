using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokedexVersionGroup
    {
        public long PokedexId { get; set; }
        public long VersionGroupId { get; set; }

        public virtual Pokedex Pokedex { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
    }
}
