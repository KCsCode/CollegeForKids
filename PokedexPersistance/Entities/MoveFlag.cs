using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveFlag
    {
        public MoveFlag()
        {
            MoveFlagMaps = new HashSet<MoveFlagMap>();
            MoveFlagProses = new HashSet<MoveFlagProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveFlagMap> MoveFlagMaps { get; set; }
        public virtual ICollection<MoveFlagProse> MoveFlagProses { get; set; }
    }
}
