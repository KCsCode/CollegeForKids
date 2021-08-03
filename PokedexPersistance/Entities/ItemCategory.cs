using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemCategory
    {
        public ItemCategory()
        {
            ItemCategoryProses = new HashSet<ItemCategoryProse>();
            Items = new HashSet<Item>();
        }

        public long Id { get; set; }
        public long PocketId { get; set; }
        public string Identifier { get; set; }

        public virtual ItemPocket Pocket { get; set; }
        public virtual ICollection<ItemCategoryProse> ItemCategoryProses { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
