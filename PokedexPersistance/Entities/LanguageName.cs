using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class LanguageName
    {
        public long LanguageId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Language Language { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
