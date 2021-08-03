using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestKingdomName
    {
        public long KingdomId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ConquestKingdom Kingdom { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
