using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EncounterSlot
    {
        public EncounterSlot()
        {
            Encounters = new HashSet<Encounter>();
        }

        public long Id { get; set; }
        public long VersionGroupId { get; set; }
        public long EncounterMethodId { get; set; }
        public long? Slot { get; set; }
        public long? Rarity { get; set; }

        public virtual EncounterMethod EncounterMethod { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
    }
}
