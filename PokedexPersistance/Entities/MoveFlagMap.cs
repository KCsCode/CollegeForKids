using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveFlagMap
    {
        public long MoveId { get; set; }
        public long MoveFlagId { get; set; }

        public virtual Move Move { get; set; }
        public virtual MoveFlag MoveFlag { get; set; }
    }
}
