using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemName
    {
        public long ItemId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Item Item { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
