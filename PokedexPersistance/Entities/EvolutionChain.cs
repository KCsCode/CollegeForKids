using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EvolutionChain
    {
        public EvolutionChain()
        {
            PokemonSpecies = new HashSet<PokemonSpecy>();
        }

        public long Id { get; set; }
        public long? BabyTriggerItemId { get; set; }

        public virtual Item BabyTriggerItem { get; set; }
        public virtual ICollection<PokemonSpecy> PokemonSpecies { get; set; }
    }
}
