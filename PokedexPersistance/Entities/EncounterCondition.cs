using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EncounterCondition
    {
        public EncounterCondition()
        {
            EncounterConditionProses = new HashSet<EncounterConditionProse>();
            EncounterConditionValues = new HashSet<EncounterConditionValue>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<EncounterConditionProse> EncounterConditionProses { get; set; }
        public virtual ICollection<EncounterConditionValue> EncounterConditionValues { get; set; }
    }
}
