using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Type
    {
        public Type()
        {
            Berries = new HashSet<Berry>();
            ConquestKingdoms = new HashSet<ConquestKingdom>();
            ConquestWarriorSpecialties = new HashSet<ConquestWarriorSpecialty>();
            ConquestWarriorTransformations = new HashSet<ConquestWarriorTransformation>();
            MoveChangelogs = new HashSet<MoveChangelog>();
            Moves = new HashSet<Move>();
            PokemonEvolutionKnownMoveTypes = new HashSet<PokemonEvolution>();
            PokemonEvolutionPartyTypes = new HashSet<PokemonEvolution>();
            PokemonTypes = new HashSet<PokemonType>();
            TypeEfficacyDamageTypes = new HashSet<TypeEfficacy>();
            TypeEfficacyTargetTypes = new HashSet<TypeEfficacy>();
            TypeGameIndices = new HashSet<TypeGameIndex>();
            TypeNames = new HashSet<TypeName>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenerationId { get; set; }
        public long? DamageClassId { get; set; }

        public virtual MoveDamageClass DamageClass { get; set; }
        public virtual Generation Generation { get; set; }
        public virtual ICollection<Berry> Berries { get; set; }
        public virtual ICollection<ConquestKingdom> ConquestKingdoms { get; set; }
        public virtual ICollection<ConquestWarriorSpecialty> ConquestWarriorSpecialties { get; set; }
        public virtual ICollection<ConquestWarriorTransformation> ConquestWarriorTransformations { get; set; }
        public virtual ICollection<MoveChangelog> MoveChangelogs { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionKnownMoveTypes { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionPartyTypes { get; set; }
        public virtual ICollection<PokemonType> PokemonTypes { get; set; }
        public virtual ICollection<TypeEfficacy> TypeEfficacyDamageTypes { get; set; }
        public virtual ICollection<TypeEfficacy> TypeEfficacyTargetTypes { get; set; }
        public virtual ICollection<TypeGameIndex> TypeGameIndices { get; set; }
        public virtual ICollection<TypeName> TypeNames { get; set; }
    }
}
