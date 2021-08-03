using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Move
    {
        public Move()
        {
            ConquestPokemonMoves = new HashSet<ConquestPokemonMove>();
            ContestComboFirstMoves = new HashSet<ContestCombo>();
            ContestComboSecondMoves = new HashSet<ContestCombo>();
            Machines = new HashSet<Machine>();
            MoveChangelogs = new HashSet<MoveChangelog>();
            MoveFlagMaps = new HashSet<MoveFlagMap>();
            MoveFlavorSummaries = new HashSet<MoveFlavorSummary>();
            MoveFlavorTexts = new HashSet<MoveFlavorText>();
            MoveMetaStatChanges = new HashSet<MoveMetaStatChange>();
            MoveNames = new HashSet<MoveName>();
            PokemonEvolutions = new HashSet<PokemonEvolution>();
            PokemonMoves = new HashSet<PokemonMove>();
            SuperContestComboFirstMoves = new HashSet<SuperContestCombo>();
            SuperContestComboSecondMoves = new HashSet<SuperContestCombo>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenerationId { get; set; }
        public long TypeId { get; set; }
        public long? Power { get; set; }
        public long? Pp { get; set; }
        public long? Accuracy { get; set; }
        public long Priority { get; set; }
        public long TargetId { get; set; }
        public long DamageClassId { get; set; }
        public long EffectId { get; set; }
        public long? EffectChance { get; set; }
        public long? ContestTypeId { get; set; }
        public long? ContestEffectId { get; set; }
        public long? SuperContestEffectId { get; set; }

        public virtual ContestEffect ContestEffect { get; set; }
        public virtual ContestType ContestType { get; set; }
        public virtual MoveDamageClass DamageClass { get; set; }
        public virtual MoveEffect Effect { get; set; }
        public virtual Generation Generation { get; set; }
        public virtual SuperContestEffect SuperContestEffect { get; set; }
        public virtual MoveTarget Target { get; set; }
        public virtual Type Type { get; set; }
        public virtual ConquestMoveDatum ConquestMoveDatum { get; set; }
        public virtual MoveMetum MoveMetum { get; set; }
        public virtual ICollection<ConquestPokemonMove> ConquestPokemonMoves { get; set; }
        public virtual ICollection<ContestCombo> ContestComboFirstMoves { get; set; }
        public virtual ICollection<ContestCombo> ContestComboSecondMoves { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
        public virtual ICollection<MoveChangelog> MoveChangelogs { get; set; }
        public virtual ICollection<MoveFlagMap> MoveFlagMaps { get; set; }
        public virtual ICollection<MoveFlavorSummary> MoveFlavorSummaries { get; set; }
        public virtual ICollection<MoveFlavorText> MoveFlavorTexts { get; set; }
        public virtual ICollection<MoveMetaStatChange> MoveMetaStatChanges { get; set; }
        public virtual ICollection<MoveName> MoveNames { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutions { get; set; }
        public virtual ICollection<PokemonMove> PokemonMoves { get; set; }
        public virtual ICollection<SuperContestCombo> SuperContestComboFirstMoves { get; set; }
        public virtual ICollection<SuperContestCombo> SuperContestComboSecondMoves { get; set; }
    }
}
