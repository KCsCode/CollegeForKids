using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveRange
    {
        public ConquestMoveRange()
        {
            ConquestMoveData = new HashSet<ConquestMoveDatum>();
            ConquestMoveRangeProses = new HashSet<ConquestMoveRangeProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long Targets { get; set; }

        public virtual ICollection<ConquestMoveDatum> ConquestMoveData { get; set; }
        public virtual ICollection<ConquestMoveRangeProse> ConquestMoveRangeProses { get; set; }
    }
}
