using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class VersionGroupRegion
    {
        public long VersionGroupId { get; set; }
        public long RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
    }
}
