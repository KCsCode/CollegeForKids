using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonColor
    {
        public PokemonColor()
        {
            PokemonColorNames = new HashSet<PokemonColorName>();
            PokemonSpecies = new HashSet<PokemonSpecy>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonColorName> PokemonColorNames { get; set; }
        public virtual ICollection<PokemonSpecy> PokemonSpecies { get; set; }
    }
}
