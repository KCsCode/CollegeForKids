using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemPocket
    {
        public ItemPocket()
        {
            ItemCategories = new HashSet<ItemCategory>();
            ItemPocketNames = new HashSet<ItemPocketName>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ItemCategory> ItemCategories { get; set; }
        public virtual ICollection<ItemPocketName> ItemPocketNames { get; set; }
    }
}
