using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonAbility
    {
        public long PokemonId { get; set; }
        public long AbilityId { get; set; }
        public byte[] IsHidden { get; set; }
        public long Slot { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Pokemon Pokemon { get; set; }
    }
}
