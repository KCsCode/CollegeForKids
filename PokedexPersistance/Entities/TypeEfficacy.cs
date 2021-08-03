using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class TypeEfficacy
    {
        public long DamageTypeId { get; set; }
        public long TargetTypeId { get; set; }
        public long DamageFactor { get; set; }

        public virtual Type DamageType { get; set; }
        public virtual Type TargetType { get; set; }
    }
}
