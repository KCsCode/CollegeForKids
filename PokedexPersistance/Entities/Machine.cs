using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Machine
    {
        public long MachineNumber { get; set; }
        public long VersionGroupId { get; set; }
        public long ItemId { get; set; }
        public long MoveId { get; set; }

        public virtual Item Item { get; set; }
        public virtual Move Move { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
    }
}
