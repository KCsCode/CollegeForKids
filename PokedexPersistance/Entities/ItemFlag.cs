using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemFlag
    {
        public ItemFlag()
        {
            ItemFlagMaps = new HashSet<ItemFlagMap>();
            ItemFlagProses = new HashSet<ItemFlagProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ItemFlagMap> ItemFlagMaps { get; set; }
        public virtual ICollection<ItemFlagProse> ItemFlagProses { get; set; }
    }
}
