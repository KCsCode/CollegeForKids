using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class AbilityChangelog
    {
        public AbilityChangelog()
        {
            AbilityChangelogProses = new HashSet<AbilityChangelogProse>();
        }

        public long Id { get; set; }
        public long AbilityId { get; set; }
        public long ChangedInVersionGroupId { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual VersionGroup ChangedInVersionGroup { get; set; }
        public virtual ICollection<AbilityChangelogProse> AbilityChangelogProses { get; set; }
    }
}
