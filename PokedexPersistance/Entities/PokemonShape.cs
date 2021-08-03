using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonShape
    {
        public PokemonShape()
        {
            PokemonShapeProses = new HashSet<PokemonShapeProse>();
            PokemonSpecies = new HashSet<PokemonSpecy>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonShapeProse> PokemonShapeProses { get; set; }
        public virtual ICollection<PokemonSpecy> PokemonSpecies { get; set; }
    }
}
