using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveMetaCategoryProse
    {
        public long MoveMetaCategoryId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Description { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual MoveMetaCategory MoveMetaCategory { get; set; }
    }
}
