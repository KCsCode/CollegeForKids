using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveTarget
    {
        public MoveTarget()
        {
            MoveChangelogs = new HashSet<MoveChangelog>();
            MoveTargetProses = new HashSet<MoveTargetProse>();
            Moves = new HashSet<Move>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveChangelog> MoveChangelogs { get; set; }
        public virtual ICollection<MoveTargetProse> MoveTargetProses { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
    }
}
