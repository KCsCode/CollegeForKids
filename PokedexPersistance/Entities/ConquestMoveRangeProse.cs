using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveRangeProse
    {
        public long ConquestMoveRangeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ConquestMoveRange ConquestMoveRange { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
