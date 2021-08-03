using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EncounterConditionValue
    {
        public EncounterConditionValue()
        {
            EncounterConditionValueMaps = new HashSet<EncounterConditionValueMap>();
            EncounterConditionValueProses = new HashSet<EncounterConditionValueProse>();
        }

        public long Id { get; set; }
        public long EncounterConditionId { get; set; }
        public string Identifier { get; set; }
        public byte[] IsDefault { get; set; }

        public virtual EncounterCondition EncounterCondition { get; set; }
        public virtual ICollection<EncounterConditionValueMap> EncounterConditionValueMaps { get; set; }
        public virtual ICollection<EncounterConditionValueProse> EncounterConditionValueProses { get; set; }
    }
}
