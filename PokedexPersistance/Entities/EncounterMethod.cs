using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EncounterMethod
    {
        public EncounterMethod()
        {
            EncounterMethodProses = new HashSet<EncounterMethodProse>();
            EncounterSlots = new HashSet<EncounterSlot>();
            LocationAreaEncounterRates = new HashSet<LocationAreaEncounterRate>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long Order { get; set; }

        public virtual ICollection<EncounterMethodProse> EncounterMethodProses { get; set; }
        public virtual ICollection<EncounterSlot> EncounterSlots { get; set; }
        public virtual ICollection<LocationAreaEncounterRate> LocationAreaEncounterRates { get; set; }
    }
}
