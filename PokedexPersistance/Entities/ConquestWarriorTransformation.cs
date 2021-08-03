using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorTransformation
    {
        public ConquestWarriorTransformation()
        {
            ConquestTransformationPokemons = new HashSet<ConquestTransformationPokemon>();
            ConquestTransformationWarriors = new HashSet<ConquestTransformationWarrior>();
        }

        public long TransformedWarriorRankId { get; set; }
        public byte[] IsAutomatic { get; set; }
        public long? RequiredLink { get; set; }
        public long? CompletedEpisodeId { get; set; }
        public long? CurrentEpisodeId { get; set; }
        public long? DistantWarriorId { get; set; }
        public long? FemaleWarlordCount { get; set; }
        public long? PokemonCount { get; set; }
        public long? CollectionTypeId { get; set; }
        public long? WarriorCount { get; set; }

        public virtual Type CollectionType { get; set; }
        public virtual ConquestEpisode CompletedEpisode { get; set; }
        public virtual ConquestEpisode CurrentEpisode { get; set; }
        public virtual ConquestWarrior DistantWarrior { get; set; }
        public virtual ConquestWarriorRank TransformedWarriorRank { get; set; }
        public virtual ICollection<ConquestTransformationPokemon> ConquestTransformationPokemons { get; set; }
        public virtual ICollection<ConquestTransformationWarrior> ConquestTransformationWarriors { get; set; }
    }
}
