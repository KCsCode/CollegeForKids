using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Nature
    {
        public Nature()
        {
            NatureBattleStylePreferences = new HashSet<NatureBattleStylePreference>();
            NatureNames = new HashSet<NatureName>();
            NaturePokeathlonStats = new HashSet<NaturePokeathlonStat>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long DecreasedStatId { get; set; }
        public long IncreasedStatId { get; set; }
        public long HatesFlavorId { get; set; }
        public long LikesFlavorId { get; set; }
        public long GameIndex { get; set; }

        public virtual Stat DecreasedStat { get; set; }
        public virtual ContestType HatesFlavor { get; set; }
        public virtual Stat IncreasedStat { get; set; }
        public virtual ContestType LikesFlavor { get; set; }
        public virtual ICollection<NatureBattleStylePreference> NatureBattleStylePreferences { get; set; }
        public virtual ICollection<NatureName> NatureNames { get; set; }
        public virtual ICollection<NaturePokeathlonStat> NaturePokeathlonStats { get; set; }
    }
}
