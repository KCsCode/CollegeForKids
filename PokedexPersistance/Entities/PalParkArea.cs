using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PalParkArea
    {
        public PalParkArea()
        {
            PalParkAreaNames = new HashSet<PalParkAreaName>();
            PalParks = new HashSet<PalPark>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PalParkAreaName> PalParkAreaNames { get; set; }
        public virtual ICollection<PalPark> PalParks { get; set; }
    }
}
