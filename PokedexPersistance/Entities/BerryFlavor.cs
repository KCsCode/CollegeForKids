using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class BerryFlavor
    {
        public long BerryId { get; set; }
        public long ContestTypeId { get; set; }
        public long Flavor { get; set; }

        public virtual Berry Berry { get; set; }
        public virtual ContestType ContestType { get; set; }
    }
}
