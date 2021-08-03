using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonMoveMethod
    {
        public PokemonMoveMethod()
        {
            PokemonMoveMethodProses = new HashSet<PokemonMoveMethodProse>();
            PokemonMoves = new HashSet<PokemonMove>();
            VersionGroupPokemonMoveMethods = new HashSet<VersionGroupPokemonMoveMethod>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonMoveMethodProse> PokemonMoveMethodProses { get; set; }
        public virtual ICollection<PokemonMove> PokemonMoves { get; set; }
        public virtual ICollection<VersionGroupPokemonMoveMethod> VersionGroupPokemonMoveMethods { get; set; }
    }
}
