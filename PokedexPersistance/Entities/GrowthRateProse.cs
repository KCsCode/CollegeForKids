using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class GrowthRateProse
    {
        public long GrowthRateId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual GrowthRate GrowthRate { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
