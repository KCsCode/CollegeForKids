using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ContestTypeName
    {
        public long ContestTypeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Flavor { get; set; }
        public string Color { get; set; }

        public virtual ContestType ContestType { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
