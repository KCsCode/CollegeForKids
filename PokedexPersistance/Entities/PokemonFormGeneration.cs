using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonFormGeneration
    {
        public long PokemonFormId { get; set; }
        public long GenerationId { get; set; }
        public long GameIndex { get; set; }

        public virtual Generation Generation { get; set; }
        public virtual PokemonForm PokemonForm { get; set; }
    }
}
