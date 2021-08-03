using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            Encounters = new HashSet<Encounter>();
            PokemonAbilities = new HashSet<PokemonAbility>();
            PokemonForms = new HashSet<PokemonForm>();
            PokemonGameIndices = new HashSet<PokemonGameIndex>();
            PokemonItems = new HashSet<PokemonItem>();
            PokemonMoves = new HashSet<PokemonMove>();
            PokemonStats = new HashSet<PokemonStat>();
            PokemonTypes = new HashSet<PokemonType>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long? SpeciesId { get; set; }
        public long Height { get; set; }
        public long Weight { get; set; }
        public long BaseExperience { get; set; }
        public long Order { get; set; }
        public byte[] IsDefault { get; set; }

        public virtual PokemonSpecy Species { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
        public virtual ICollection<PokemonAbility> PokemonAbilities { get; set; }
        public virtual ICollection<PokemonForm> PokemonForms { get; set; }
        public virtual ICollection<PokemonGameIndex> PokemonGameIndices { get; set; }
        public virtual ICollection<PokemonItem> PokemonItems { get; set; }
        public virtual ICollection<PokemonMove> PokemonMoves { get; set; }
        public virtual ICollection<PokemonStat> PokemonStats { get; set; }
        public virtual ICollection<PokemonType> PokemonTypes { get; set; }
    }
}
