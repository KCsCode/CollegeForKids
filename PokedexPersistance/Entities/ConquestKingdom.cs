using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestKingdom
    {
        public ConquestKingdom()
        {
            ConquestKingdomNames = new HashSet<ConquestKingdomName>();
            ConquestPokemonEvolutions = new HashSet<ConquestPokemonEvolution>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long TypeId { get; set; }

        public virtual Type Type { get; set; }
        public virtual ICollection<ConquestKingdomName> ConquestKingdomNames { get; set; }
        public virtual ICollection<ConquestPokemonEvolution> ConquestPokemonEvolutions { get; set; }
    }
}
