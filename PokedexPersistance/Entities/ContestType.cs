using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ContestType
    {
        public ContestType()
        {
            BerryFlavors = new HashSet<BerryFlavor>();
            ContestTypeNames = new HashSet<ContestTypeName>();
            Moves = new HashSet<Move>();
            NatureHatesFlavors = new HashSet<Nature>();
            NatureLikesFlavors = new HashSet<Nature>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<BerryFlavor> BerryFlavors { get; set; }
        public virtual ICollection<ContestTypeName> ContestTypeNames { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<Nature> NatureHatesFlavors { get; set; }
        public virtual ICollection<Nature> NatureLikesFlavors { get; set; }
    }
}
