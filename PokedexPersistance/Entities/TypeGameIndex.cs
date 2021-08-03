using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class TypeGameIndex
    {
        public long TypeId { get; set; }
        public long GenerationId { get; set; }
        public long GameIndex { get; set; }

        public virtual Generation Generation { get; set; }
        public virtual Type Type { get; set; }
    }
}
