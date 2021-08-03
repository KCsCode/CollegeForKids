using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveBattleStyle
    {
        public MoveBattleStyle()
        {
            MoveBattleStyleProses = new HashSet<MoveBattleStyleProse>();
            NatureBattleStylePreferences = new HashSet<NatureBattleStylePreference>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveBattleStyleProse> MoveBattleStyleProses { get; set; }
        public virtual ICollection<NatureBattleStylePreference> NatureBattleStylePreferences { get; set; }
    }
}
