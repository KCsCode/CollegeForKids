using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class TypeName
    {
        public long TypeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual Type Type { get; set; }
    }
}
