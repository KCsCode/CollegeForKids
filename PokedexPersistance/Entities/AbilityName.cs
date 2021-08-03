using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class AbilityName
    {
        public long AbilityId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
