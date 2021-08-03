using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class LocationAreaEncounterRate
    {
        public long LocationAreaId { get; set; }
        public long EncounterMethodId { get; set; }
        public long VersionId { get; set; }
        public long? Rate { get; set; }

        public virtual EncounterMethod EncounterMethod { get; set; }
        public virtual LocationArea LocationArea { get; set; }
        public virtual Version Version { get; set; }
    }
}
