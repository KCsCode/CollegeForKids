using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class EggGroupProse
    {
        public long EggGroupId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual EggGroup EggGroup { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
