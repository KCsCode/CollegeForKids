using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ContestEffectProse
    {
        public long ContestEffectId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FlavorText { get; set; }
        public string Effect { get; set; }

        public virtual ContestEffect ContestEffect { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
