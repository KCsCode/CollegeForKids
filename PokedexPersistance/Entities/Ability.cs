using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Ability
    {
        public Ability()
        {
            AbilityChangelogs = new HashSet<AbilityChangelog>();
            AbilityFlavorTexts = new HashSet<AbilityFlavorText>();
            AbilityNames = new HashSet<AbilityName>();
            AbilityProses = new HashSet<AbilityProse>();
            ConquestPokemonAbilities = new HashSet<ConquestPokemonAbility>();
            PokemonAbilities = new HashSet<PokemonAbility>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenerationId { get; set; }
        public byte[] IsMainSeries { get; set; }

        public virtual Generation Generation { get; set; }
        public virtual ICollection<AbilityChangelog> AbilityChangelogs { get; set; }
        public virtual ICollection<AbilityFlavorText> AbilityFlavorTexts { get; set; }
        public virtual ICollection<AbilityName> AbilityNames { get; set; }
        public virtual ICollection<AbilityProse> AbilityProses { get; set; }
        public virtual ICollection<ConquestPokemonAbility> ConquestPokemonAbilities { get; set; }
        public virtual ICollection<PokemonAbility> PokemonAbilities { get; set; }
    }
}
