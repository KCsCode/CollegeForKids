using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class AbilityFlavorText
    {
        public long AbilityId { get; set; }
        public long VersionGroupId { get; set; }
        public long LanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Language Language { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
    }
}
