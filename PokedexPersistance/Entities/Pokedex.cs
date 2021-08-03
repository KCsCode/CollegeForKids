using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Pokedex
    {
        public Pokedex()
        {
            PokedexProses = new HashSet<PokedexProse>();
            PokedexVersionGroups = new HashSet<PokedexVersionGroup>();
            PokemonDexNumbers = new HashSet<PokemonDexNumber>();
        }

        public long Id { get; set; }
        public long? RegionId { get; set; }
        public string Identifier { get; set; }
        public byte[] IsMainSeries { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<PokedexProse> PokedexProses { get; set; }
        public virtual ICollection<PokedexVersionGroup> PokedexVersionGroups { get; set; }
        public virtual ICollection<PokemonDexNumber> PokemonDexNumbers { get; set; }
    }
}
