using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Generation
    {
        public Generation()
        {
            Abilities = new HashSet<Ability>();
            GenerationNames = new HashSet<GenerationName>();
            ItemGameIndices = new HashSet<ItemGameIndex>();
            LocationGameIndices = new HashSet<LocationGameIndex>();
            Moves = new HashSet<Move>();
            PokemonFormGenerations = new HashSet<PokemonFormGeneration>();
            PokemonSpecies = new HashSet<PokemonSpecy>();
            TypeGameIndices = new HashSet<TypeGameIndex>();
            Types = new HashSet<Type>();
            VersionGroups = new HashSet<VersionGroup>();
        }

        public long Id { get; set; }
        public long MainRegionId { get; set; }
        public string Identifier { get; set; }

        public virtual Region MainRegion { get; set; }
        public virtual ICollection<Ability> Abilities { get; set; }
        public virtual ICollection<GenerationName> GenerationNames { get; set; }
        public virtual ICollection<ItemGameIndex> ItemGameIndices { get; set; }
        public virtual ICollection<LocationGameIndex> LocationGameIndices { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<PokemonFormGeneration> PokemonFormGenerations { get; set; }
        public virtual ICollection<PokemonSpecy> PokemonSpecies { get; set; }
        public virtual ICollection<TypeGameIndex> TypeGameIndices { get; set; }
        public virtual ICollection<Type> Types { get; set; }
        public virtual ICollection<VersionGroup> VersionGroups { get; set; }
    }
}
