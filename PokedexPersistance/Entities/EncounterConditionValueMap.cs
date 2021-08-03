using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EncounterConditionValueMap
    {
        public long EncounterId { get; set; }
        public long EncounterConditionValueId { get; set; }

        public virtual Encounter Encounter { get; set; }
        public virtual EncounterConditionValue EncounterConditionValue { get; set; }
    }
}
