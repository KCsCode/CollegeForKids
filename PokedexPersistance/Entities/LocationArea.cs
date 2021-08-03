using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class LocationArea
    {
        public LocationArea()
        {
            Encounters = new HashSet<Encounter>();
            LocationAreaEncounterRates = new HashSet<LocationAreaEncounterRate>();
            LocationAreaProses = new HashSet<LocationAreaProse>();
        }

        public long Id { get; set; }
        public long LocationId { get; set; }
        public long GameIndex { get; set; }
        public string Identifier { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
        public virtual ICollection<LocationAreaEncounterRate> LocationAreaEncounterRates { get; set; }
        public virtual ICollection<LocationAreaProse> LocationAreaProses { get; set; }
    }
}
