using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class MoveDamageClass
    {
        public MoveDamageClass()
        {
            MoveDamageClassProses = new HashSet<MoveDamageClassProse>();
            Moves = new HashSet<Move>();
            Stats = new HashSet<Stat>();
            Types = new HashSet<Type>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveDamageClassProse> MoveDamageClassProses { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<Stat> Stats { get; set; }
        public virtual ICollection<Type> Types { get; set; }
    }
}
