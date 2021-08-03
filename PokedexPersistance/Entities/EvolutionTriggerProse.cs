using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EvolutionTriggerProse
    {
        public long EvolutionTriggerId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual EvolutionTrigger EvolutionTrigger { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
