using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveDisplacement
    {
        public ConquestMoveDisplacement()
        {
            ConquestMoveData = new HashSet<ConquestMoveDatum>();
            ConquestMoveDisplacementProses = new HashSet<ConquestMoveDisplacementProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public byte[] AffectsTarget { get; set; }

        public virtual ICollection<ConquestMoveDatum> ConquestMoveData { get; set; }
        public virtual ICollection<ConquestMoveDisplacementProse> ConquestMoveDisplacementProses { get; set; }
    }
}
