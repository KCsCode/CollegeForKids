using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveFlavorSummary
    {
        public long MoveId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FlavorSummary { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual Move Move { get; set; }
    }
}
