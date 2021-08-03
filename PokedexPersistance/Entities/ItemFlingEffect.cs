using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemFlingEffect
    {
        public ItemFlingEffect()
        {
            ItemFlingEffectProses = new HashSet<ItemFlingEffectProse>();
            Items = new HashSet<Item>();
        }

        public long Id { get; set; }

        public virtual ICollection<ItemFlingEffectProse> ItemFlingEffectProses { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
