using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Gender
    {
        public Gender()
        {
            ConquestPokemonEvolutions = new HashSet<ConquestPokemonEvolution>();
            ConquestWarriors = new HashSet<ConquestWarrior>();
            PokemonEvolutions = new HashSet<PokemonEvolution>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestPokemonEvolution> ConquestPokemonEvolutions { get; set; }
        public virtual ICollection<ConquestWarrior> ConquestWarriors { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutions { get; set; }
    }
}
