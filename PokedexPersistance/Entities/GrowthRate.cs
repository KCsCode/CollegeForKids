using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class GrowthRate
    {
        public GrowthRate()
        {
            Experiences = new HashSet<Experience>();
            GrowthRateProses = new HashSet<GrowthRateProse>();
            PokemonSpecies = new HashSet<PokemonSpecy>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public string Formula { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<GrowthRateProse> GrowthRateProses { get; set; }
        public virtual ICollection<PokemonSpecy> PokemonSpecies { get; set; }
    }
}
