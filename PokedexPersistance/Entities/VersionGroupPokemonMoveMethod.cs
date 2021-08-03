using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class VersionGroupPokemonMoveMethod
    {
        public long VersionGroupId { get; set; }
        public long PokemonMoveMethodId { get; set; }

        public virtual PokemonMoveMethod PokemonMoveMethod { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
    }
}
