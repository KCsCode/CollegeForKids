using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveMetaStatChange
    {
        public long MoveId { get; set; }
        public long StatId { get; set; }
        public long Change { get; set; }

        public virtual Move Move { get; set; }
        public virtual Stat Stat { get; set; }
    }
}
