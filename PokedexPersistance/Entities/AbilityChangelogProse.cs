using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class AbilityChangelogProse
    {
        public long AbilityChangelogId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Effect { get; set; }

        public virtual AbilityChangelog AbilityChangelog { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
