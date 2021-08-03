using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class CharacteristicText
    {
        public long CharacteristicId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Message { get; set; }

        public virtual Characteristic Characteristic { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
