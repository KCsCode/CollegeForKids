using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestStat
    {
        public ConquestStat()
        {
            ConquestPokemonEvolutions = new HashSet<ConquestPokemonEvolution>();
            ConquestPokemonStats = new HashSet<ConquestPokemonStat>();
            ConquestStatNames = new HashSet<ConquestStatName>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public byte[] IsBase { get; set; }

        public virtual ICollection<ConquestPokemonEvolution> ConquestPokemonEvolutions { get; set; }
        public virtual ICollection<ConquestPokemonStat> ConquestPokemonStats { get; set; }
        public virtual ICollection<ConquestStatName> ConquestStatNames { get; set; }
    }
}
