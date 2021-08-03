using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class AbilityProse
    {
        public long AbilityId { get; set; }
        public long LocalLanguageId { get; set; }
        public string ShortEffect { get; set; }
        public string Effect { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
