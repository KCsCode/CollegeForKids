using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Region
    {
        public Region()
        {
            Generations = new HashSet<Generation>();
            Locations = new HashSet<Location>();
            Pokedices = new HashSet<Pokedex>();
            RegionNames = new HashSet<RegionName>();
            VersionGroupRegions = new HashSet<VersionGroupRegion>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<Generation> Generations { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Pokedex> Pokedices { get; set; }
        public virtual ICollection<RegionName> RegionNames { get; set; }
        public virtual ICollection<VersionGroupRegion> VersionGroupRegions { get; set; }
    }
}
