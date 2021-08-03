using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemFlavorText
    {
        public long ItemId { get; set; }
        public long VersionGroupId { get; set; }
        public long LanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Item Item { get; set; }
        public virtual Language Language { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }
    }
}
