using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveMetaCategory
    {
        public MoveMetaCategory()
        {
            MoveMeta = new HashSet<MoveMetum>();
            MoveMetaCategoryProses = new HashSet<MoveMetaCategoryProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveMetum> MoveMeta { get; set; }
        public virtual ICollection<MoveMetaCategoryProse> MoveMetaCategoryProses { get; set; }
    }
}
