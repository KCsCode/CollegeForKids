using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class LocationName
    {
        public long LocationId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual Location Location { get; set; }
    }
}
