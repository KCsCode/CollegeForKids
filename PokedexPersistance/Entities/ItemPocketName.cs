using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ItemPocketName
    {
        public long ItemPocketId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ItemPocket ItemPocket { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
