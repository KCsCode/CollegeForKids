using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonFormName
    {
        public long PokemonFormId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FormName { get; set; }
        public string PokemonName { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual PokemonForm PokemonForm { get; set; }
    }
}
