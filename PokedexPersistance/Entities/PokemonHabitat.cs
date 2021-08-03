using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonHabitat
    {
        public PokemonHabitat()
        {
            PokemonHabitatNames = new HashSet<PokemonHabitatName>();
            PokemonSpecies = new HashSet<PokemonSpecy>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonHabitatName> PokemonHabitatNames { get; set; }
        public virtual ICollection<PokemonSpecy> PokemonSpecies { get; set; }
    }
}
