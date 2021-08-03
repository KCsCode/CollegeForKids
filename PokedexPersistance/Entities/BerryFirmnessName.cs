using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class BerryFirmnessName
    {
        public long BerryFirmnessId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual BerryFirmness BerryFirmness { get; set; }
        public virtual Language LocalLanguage { get; set; }
    }
}
