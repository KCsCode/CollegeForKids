using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class LocationAreaProse
    {
        public long LocationAreaId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual LocationArea LocationArea { get; set; }
    }
}
