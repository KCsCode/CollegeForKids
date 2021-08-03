using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemFlingEffectProse
    {
        public long ItemFlingEffectId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Effect { get; set; }

        public virtual ItemFlingEffect ItemFlingEffect { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
