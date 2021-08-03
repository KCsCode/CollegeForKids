using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestMaxLink
    {
        public long WarriorRankId { get; set; }
        public long PokemonSpeciesId { get; set; }
        public long MaxLink { get; set; }

        public virtual PokemonSpecy PokemonSpecies { get; set; }
        public virtual ConquestWarriorRank WarriorRank { get; set; }
    }
}
