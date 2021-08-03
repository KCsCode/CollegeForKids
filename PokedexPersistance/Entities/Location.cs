using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Location
    {
        public Location()
        {
            LocationAreas = new HashSet<LocationArea>();
            LocationGameIndices = new HashSet<LocationGameIndex>();
            LocationNames = new HashSet<LocationName>();
            PokemonEvolutions = new HashSet<PokemonEvolution>();
        }

        public long Id { get; set; }
        public long? RegionId { get; set; }
        public string Identifier { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<LocationArea> LocationAreas { get; set; }
        public virtual ICollection<LocationGameIndex> LocationGameIndices { get; set; }
        public virtual ICollection<LocationName> LocationNames { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutions { get; set; }
    }
}
