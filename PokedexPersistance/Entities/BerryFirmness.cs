using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class BerryFirmness
    {
        public BerryFirmness()
        {
            Berries = new HashSet<Berry>();
            BerryFirmnessNames = new HashSet<BerryFirmnessName>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<Berry> Berries { get; set; }
        public virtual ICollection<BerryFirmnessName> BerryFirmnessNames { get; set; }
    }
}
