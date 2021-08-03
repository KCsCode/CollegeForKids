using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EncounterMethodProse
    {
        public long EncounterMethodId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual EncounterMethod EncounterMethod { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
