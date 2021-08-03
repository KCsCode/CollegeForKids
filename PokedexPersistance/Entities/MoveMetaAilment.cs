using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveMetaAilment
    {
        public MoveMetaAilment()
        {
            MoveMeta = new HashSet<MoveMetum>();
            MoveMetaAilmentNames = new HashSet<MoveMetaAilmentName>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveMetum> MoveMeta { get; set; }
        public virtual ICollection<MoveMetaAilmentName> MoveMetaAilmentNames { get; set; }
    }
}
