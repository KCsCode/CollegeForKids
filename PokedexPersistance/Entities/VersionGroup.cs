using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class VersionGroup
    {
        public VersionGroup()
        {
            AbilityChangelogs = new HashSet<AbilityChangelog>();
            AbilityFlavorTexts = new HashSet<AbilityFlavorText>();
            EncounterSlots = new HashSet<EncounterSlot>();
            ItemFlavorTexts = new HashSet<ItemFlavorText>();
            Machines = new HashSet<Machine>();
            MoveChangelogs = new HashSet<MoveChangelog>();
            MoveEffectChangelogs = new HashSet<MoveEffectChangelog>();
            MoveFlavorTexts = new HashSet<MoveFlavorText>();
            PokedexVersionGroups = new HashSet<PokedexVersionGroup>();
            PokemonForms = new HashSet<PokemonForm>();
            PokemonMoves = new HashSet<PokemonMove>();
            VersionGroupPokemonMoveMethods = new HashSet<VersionGroupPokemonMoveMethod>();
            VersionGroupRegions = new HashSet<VersionGroupRegion>();
            Versions = new HashSet<Version>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenerationId { get; set; }
        public long? Order { get; set; }

        public virtual Generation Generation { get; set; }
        public virtual ICollection<AbilityChangelog> AbilityChangelogs { get; set; }
        public virtual ICollection<AbilityFlavorText> AbilityFlavorTexts { get; set; }
        public virtual ICollection<EncounterSlot> EncounterSlots { get; set; }
        public virtual ICollection<ItemFlavorText> ItemFlavorTexts { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
        public virtual ICollection<MoveChangelog> MoveChangelogs { get; set; }
        public virtual ICollection<MoveEffectChangelog> MoveEffectChangelogs { get; set; }
        public virtual ICollection<MoveFlavorText> MoveFlavorTexts { get; set; }
        public virtual ICollection<PokedexVersionGroup> PokedexVersionGroups { get; set; }
        public virtual ICollection<PokemonForm> PokemonForms { get; set; }
        public virtual ICollection<PokemonMove> PokemonMoves { get; set; }
        public virtual ICollection<VersionGroupPokemonMoveMethod> VersionGroupPokemonMoveMethods { get; set; }
        public virtual ICollection<VersionGroupRegion> VersionGroupRegions { get; set; }
        public virtual ICollection<Version> Versions { get; set; }
    }
}
