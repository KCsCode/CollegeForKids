using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemCategoryProse
    {
        public long ItemCategoryId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
