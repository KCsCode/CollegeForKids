using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestTransformationPokemon
    {
        public long TransformationId { get; set; }
        public long PokemonSpeciesId { get; set; }

        public virtual PokemonSpecy PokemonSpecies { get; set; }
        public virtual ConquestWarriorTransformation Transformation { get; set; }
    }
}
