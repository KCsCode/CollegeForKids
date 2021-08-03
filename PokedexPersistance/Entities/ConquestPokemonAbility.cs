using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestPokemonAbility
    {
        public long PokemonSpeciesId { get; set; }
        public long Slot { get; set; }
        public long AbilityId { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual PokemonSpecy PokemonSpecies { get; set; }
    }
}
