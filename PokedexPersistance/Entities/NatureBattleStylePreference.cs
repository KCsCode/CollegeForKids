using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class NatureBattleStylePreference
    {
        public long NatureId { get; set; }
        public long MoveBattleStyleId { get; set; }
        public long LowHpPreference { get; set; }
        public long HighHpPreference { get; set; }

        public virtual MoveBattleStyle MoveBattleStyle { get; set; }
        public virtual Nature Nature { get; set; }
    }
}
