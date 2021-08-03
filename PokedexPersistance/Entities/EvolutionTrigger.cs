using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EvolutionTrigger
    {
        public EvolutionTrigger()
        {
            EvolutionTriggerProses = new HashSet<EvolutionTriggerProse>();
            PokemonEvolutions = new HashSet<PokemonEvolution>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<EvolutionTriggerProse> EvolutionTriggerProses { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutions { get; set; }
    }
}
