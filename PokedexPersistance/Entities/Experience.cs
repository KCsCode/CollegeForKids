using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Experience
    {
        public long GrowthRateId { get; set; }
        public long Level { get; set; }
        public long Experience1 { get; set; }

        public virtual GrowthRate GrowthRate { get; set; }
    }
}
