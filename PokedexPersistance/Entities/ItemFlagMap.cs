using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemFlagMap
    {
        public long ItemId { get; set; }
        public long ItemFlagId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemFlag ItemFlag { get; set; }
    }
}
