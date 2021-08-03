using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EncounterConditionProse
    {
        public long EncounterConditionId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual EncounterCondition EncounterCondition { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
