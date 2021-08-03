using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonMove
    {
        public long PokemonId { get; set; }
        public long VersionGroupId { get; set; }
        public long MoveId { get; set; }
        public long PokemonMoveMethodId { get; set; }
        public long Level { get; set; }
        public long? Order { get; set; }

        public virtual Move Move { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual PokemonMoveMethod PokemonMoveMethod { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
    }
}
