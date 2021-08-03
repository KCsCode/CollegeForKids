using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class SuperContestCombo
    {
        public long FirstMoveId { get; set; }
        public long SecondMoveId { get; set; }

        public virtual Move FirstMove { get; set; }
        public virtual Move SecondMove { get; set; }
    }
}
