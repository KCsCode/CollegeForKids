using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveDisplacementProse
    {
        public long MoveDisplacementId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string ShortEffect { get; set; }
        public string Effect { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual ConquestMoveDisplacement MoveDisplacement { get; set; }
    }
}
