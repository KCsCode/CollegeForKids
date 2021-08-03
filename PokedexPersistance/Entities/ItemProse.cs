using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemProse
    {
        public long ItemId { get; set; }
        public long LocalLanguageId { get; set; }
        public string ShortEffect { get; set; }
        public string Effect { get; set; }

        public virtual Item Item { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
