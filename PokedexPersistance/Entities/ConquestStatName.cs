using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestStatName
    {
        public long ConquestStatId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ConquestStat ConquestStat { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
