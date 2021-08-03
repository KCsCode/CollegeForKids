using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonShapeProse
    {
        public long PokemonShapeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string AwesomeName { get; set; }
        public string Description { get; set; }

        public virtual Language LocalLanguage { get; set; }
        public virtual PokemonShape PokemonShape { get; set; }
    }
}
