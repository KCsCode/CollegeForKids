using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EggGroup
    {
        public EggGroup()
        {
            EggGroupProses = new HashSet<EggGroupProse>();
            PokemonEggGroups = new HashSet<PokemonEggGroup>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<EggGroupProse> EggGroupProses { get; set; }
        public virtual ICollection<PokemonEggGroup> PokemonEggGroups { get; set; }
    }
}
