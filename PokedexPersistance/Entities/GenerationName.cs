using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class GenerationName
    {
        public long GenerationId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Generation Generation { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
