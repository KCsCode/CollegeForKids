using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class SuperContestEffectProse
    {
        public long SuperContestEffectId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual SuperContestEffect SuperContestEffect { get; set; }
    }
}
