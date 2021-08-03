using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Encounter
    {
        public Encounter()
        {
            EncounterConditionValueMaps = new HashSet<EncounterConditionValueMap>();
        }

        public long Id { get; set; }
        public long VersionId { get; set; }
        public long LocationAreaId { get; set; }
        public long EncounterSlotId { get; set; }
        public long PokemonId { get; set; }
        public long MinLevel { get; set; }
        public long MaxLevel { get; set; }

        public virtual EncounterSlot EncounterSlot { get; set; }
        public virtual LocationArea LocationArea { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual Version Version { get; set; }
        public virtual ICollection<EncounterConditionValueMap> EncounterConditionValueMaps { get; set; }
    }
}
