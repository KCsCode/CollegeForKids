using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Characteristic
    {
        public Characteristic()
        {
            CharacteristicTexts = new HashSet<CharacteristicText>();
        }

        public long Id { get; set; }
        public long StatId { get; set; }
        public long GeneMod5 { get; set; }

        public virtual Stat Stat { get; set; }
        public virtual ICollection<CharacteristicText> CharacteristicTexts { get; set; }
    }
}
