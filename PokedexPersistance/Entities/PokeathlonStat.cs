using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokeathlonStat
    {
        public PokeathlonStat()
        {
            NaturePokeathlonStats = new HashSet<NaturePokeathlonStat>();
            PokeathlonStatNames = new HashSet<PokeathlonStatName>();
            PokemonFormPokeathlonStats = new HashSet<PokemonFormPokeathlonStat>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<NaturePokeathlonStat> NaturePokeathlonStats { get; set; }
        public virtual ICollection<PokeathlonStatName> PokeathlonStatNames { get; set; }
        public virtual ICollection<PokemonFormPokeathlonStat> PokemonFormPokeathlonStats { get; set; }
    }
}
