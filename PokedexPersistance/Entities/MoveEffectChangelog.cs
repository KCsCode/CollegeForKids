using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveEffectChangelog
    {
        public MoveEffectChangelog()
        {
            MoveEffectChangelogProses = new HashSet<MoveEffectChangelogProse>();
        }

        public long Id { get; set; }
        public long EffectId { get; set; }
        public long ChangedInVersionGroupId { get; set; }

        public virtual VersionGroup ChangedInVersionGroup { get; set; }
        public virtual MoveEffect Effect { get; set; }
        public virtual ICollection<MoveEffectChangelogProse> MoveEffectChangelogProses { get; set; }
    }
}
