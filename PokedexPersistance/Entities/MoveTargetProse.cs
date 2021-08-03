using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveTargetProse
    {
        public long MoveTargetId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual MoveTarget MoveTarget { get; set; }
    }
}
