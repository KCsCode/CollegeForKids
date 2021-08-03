using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Language
    {
        public Language()
        {
            AbilityChangelogProses = new HashSet<AbilityChangelogProse>();
            AbilityFlavorTexts = new HashSet<AbilityFlavorText>();
            AbilityNames = new HashSet<AbilityName>();
            AbilityProses = new HashSet<AbilityProse>();
            BerryFirmnessNames = new HashSet<BerryFirmnessName>();
            CharacteristicTexts = new HashSet<CharacteristicText>();
            ConquestEpisodeNames = new HashSet<ConquestEpisodeName>();
            ConquestKingdomNames = new HashSet<ConquestKingdomName>();
            ConquestMoveDisplacementProses = new HashSet<ConquestMoveDisplacementProse>();
            ConquestMoveEffectProses = new HashSet<ConquestMoveEffectProse>();
            ConquestMoveRangeProses = new HashSet<ConquestMoveRangeProse>();
            ConquestStatNames = new HashSet<ConquestStatName>();
            ConquestWarriorNames = new HashSet<ConquestWarriorName>();
            ConquestWarriorSkillNames = new HashSet<ConquestWarriorSkillName>();
            ConquestWarriorStatNames = new HashSet<ConquestWarriorStatName>();
            ContestEffectProses = new HashSet<ContestEffectProse>();
            ContestTypeNames = new HashSet<ContestTypeName>();
            EggGroupProses = new HashSet<EggGroupProse>();
            EncounterConditionProses = new HashSet<EncounterConditionProse>();
            EncounterConditionValueProses = new HashSet<EncounterConditionValueProse>();
            EncounterMethodProses = new HashSet<EncounterMethodProse>();
            EvolutionTriggerProses = new HashSet<EvolutionTriggerProse>();
            GenerationNames = new HashSet<GenerationName>();
            GrowthRateProses = new HashSet<GrowthRateProse>();
            ItemCategoryProses = new HashSet<ItemCategoryProse>();
            ItemFlagProses = new HashSet<ItemFlagProse>();
            ItemFlavorSummaries = new HashSet<ItemFlavorSummary>();
            ItemFlavorTexts = new HashSet<ItemFlavorText>();
            ItemFlingEffectProses = new HashSet<ItemFlingEffectProse>();
            ItemNames = new HashSet<ItemName>();
            ItemPocketNames = new HashSet<ItemPocketName>();
            ItemProses = new HashSet<ItemProse>();
            LanguageNameLanguages = new HashSet<LanguageName>();
            LanguageNameLocalLanguages = new HashSet<LanguageName>();
            LocationAreaProses = new HashSet<LocationAreaProse>();
            LocationNames = new HashSet<LocationName>();
            MoveBattleStyleProses = new HashSet<MoveBattleStyleProse>();
            MoveDamageClassProses = new HashSet<MoveDamageClassProse>();
            MoveEffectChangelogProses = new HashSet<MoveEffectChangelogProse>();
            MoveEffectProses = new HashSet<MoveEffectProse>();
            MoveFlagProses = new HashSet<MoveFlagProse>();
            MoveFlavorSummaries = new HashSet<MoveFlavorSummary>();
            MoveFlavorTexts = new HashSet<MoveFlavorText>();
            MoveMetaAilmentNames = new HashSet<MoveMetaAilmentName>();
            MoveMetaCategoryProses = new HashSet<MoveMetaCategoryProse>();
            MoveNames = new HashSet<MoveName>();
            MoveTargetProses = new HashSet<MoveTargetProse>();
            NatureNames = new HashSet<NatureName>();
            PalParkAreaNames = new HashSet<PalParkAreaName>();
            PokeathlonStatNames = new HashSet<PokeathlonStatName>();
            PokedexProses = new HashSet<PokedexProse>();
            PokemonColorNames = new HashSet<PokemonColorName>();
            PokemonFormNames = new HashSet<PokemonFormName>();
            PokemonHabitatNames = new HashSet<PokemonHabitatName>();
            PokemonMoveMethodProses = new HashSet<PokemonMoveMethodProse>();
            PokemonShapeProses = new HashSet<PokemonShapeProse>();
            PokemonSpeciesFlavorSummaries = new HashSet<PokemonSpeciesFlavorSummary>();
            PokemonSpeciesFlavorTexts = new HashSet<PokemonSpeciesFlavorText>();
            PokemonSpeciesNames = new HashSet<PokemonSpeciesName>();
            PokemonSpeciesProses = new HashSet<PokemonSpeciesProse>();
            RegionNames = new HashSet<RegionName>();
            StatNames = new HashSet<StatName>();
            SuperContestEffectProses = new HashSet<SuperContestEffectProse>();
            TypeNames = new HashSet<TypeName>();
            VersionNames = new HashSet<VersionName>();
        }

        public long Id { get; set; }
        public string Iso639 { get; set; }
        public string Iso3166 { get; set; }
        public string Identifier { get; set; }
        public byte[] Official { get; set; }
        public long? Order { get; set; }

        public virtual ICollection<AbilityChangelogProse> AbilityChangelogProses { get; set; }
        public virtual ICollection<AbilityFlavorText> AbilityFlavorTexts { get; set; }
        public virtual ICollection<AbilityName> AbilityNames { get; set; }
        public virtual ICollection<AbilityProse> AbilityProses { get; set; }
        public virtual ICollection<BerryFirmnessName> BerryFirmnessNames { get; set; }
        public virtual ICollection<CharacteristicText> CharacteristicTexts { get; set; }
        public virtual ICollection<ConquestEpisodeName> ConquestEpisodeNames { get; set; }
        public virtual ICollection<ConquestKingdomName> ConquestKingdomNames { get; set; }
        public virtual ICollection<ConquestMoveDisplacementProse> ConquestMoveDisplacementProses { get; set; }
        public virtual ICollection<ConquestMoveEffectProse> ConquestMoveEffectProses { get; set; }
        public virtual ICollection<ConquestMoveRangeProse> ConquestMoveRangeProses { get; set; }
        public virtual ICollection<ConquestStatName> ConquestStatNames { get; set; }
        public virtual ICollection<ConquestWarriorName> ConquestWarriorNames { get; set; }
        public virtual ICollection<ConquestWarriorSkillName> ConquestWarriorSkillNames { get; set; }
        public virtual ICollection<ConquestWarriorStatName> ConquestWarriorStatNames { get; set; }
        public virtual ICollection<ContestEffectProse> ContestEffectProses { get; set; }
        public virtual ICollection<ContestTypeName> ContestTypeNames { get; set; }
        public virtual ICollection<EggGroupProse> EggGroupProses { get; set; }
        public virtual ICollection<EncounterConditionProse> EncounterConditionProses { get; set; }
        public virtual ICollection<EncounterConditionValueProse> EncounterConditionValueProses { get; set; }
        public virtual ICollection<EncounterMethodProse> EncounterMethodProses { get; set; }
        public virtual ICollection<EvolutionTriggerProse> EvolutionTriggerProses { get; set; }
        public virtual ICollection<GenerationName> GenerationNames { get; set; }
        public virtual ICollection<GrowthRateProse> GrowthRateProses { get; set; }
        public virtual ICollection<ItemCategoryProse> ItemCategoryProses { get; set; }
        public virtual ICollection<ItemFlagProse> ItemFlagProses { get; set; }
        public virtual ICollection<ItemFlavorSummary> ItemFlavorSummaries { get; set; }
        public virtual ICollection<ItemFlavorText> ItemFlavorTexts { get; set; }
        public virtual ICollection<ItemFlingEffectProse> ItemFlingEffectProses { get; set; }
        public virtual ICollection<ItemName> ItemNames { get; set; }
        public virtual ICollection<ItemPocketName> ItemPocketNames { get; set; }
        public virtual ICollection<ItemProse> ItemProses { get; set; }
        public virtual ICollection<LanguageName> LanguageNameLanguages { get; set; }
        public virtual ICollection<LanguageName> LanguageNameLocalLanguages { get; set; }
        public virtual ICollection<LocationAreaProse> LocationAreaProses { get; set; }
        public virtual ICollection<LocationName> LocationNames { get; set; }
        public virtual ICollection<MoveBattleStyleProse> MoveBattleStyleProses { get; set; }
        public virtual ICollection<MoveDamageClassProse> MoveDamageClassProses { get; set; }
        public virtual ICollection<MoveEffectChangelogProse> MoveEffectChangelogProses { get; set; }
        public virtual ICollection<MoveEffectProse> MoveEffectProses { get; set; }
        public virtual ICollection<MoveFlagProse> MoveFlagProses { get; set; }
        public virtual ICollection<MoveFlavorSummary> MoveFlavorSummaries { get; set; }
        public virtual ICollection<MoveFlavorText> MoveFlavorTexts { get; set; }
        public virtual ICollection<MoveMetaAilmentName> MoveMetaAilmentNames { get; set; }
        public virtual ICollection<MoveMetaCategoryProse> MoveMetaCategoryProses { get; set; }
        public virtual ICollection<MoveName> MoveNames { get; set; }
        public virtual ICollection<MoveTargetProse> MoveTargetProses { get; set; }
        public virtual ICollection<NatureName> NatureNames { get; set; }
        public virtual ICollection<PalParkAreaName> PalParkAreaNames { get; set; }
        public virtual ICollection<PokeathlonStatName> PokeathlonStatNames { get; set; }
        public virtual ICollection<PokedexProse> PokedexProses { get; set; }
        public virtual ICollection<PokemonColorName> PokemonColorNames { get; set; }
        public virtual ICollection<PokemonFormName> PokemonFormNames { get; set; }
        public virtual ICollection<PokemonHabitatName> PokemonHabitatNames { get; set; }
        public virtual ICollection<PokemonMoveMethodProse> PokemonMoveMethodProses { get; set; }
        public virtual ICollection<PokemonShapeProse> PokemonShapeProses { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorSummary> PokemonSpeciesFlavorSummaries { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorText> PokemonSpeciesFlavorTexts { get; set; }
        public virtual ICollection<PokemonSpeciesName> PokemonSpeciesNames { get; set; }
        public virtual ICollection<PokemonSpeciesProse> PokemonSpeciesProses { get; set; }
        public virtual ICollection<RegionName> RegionNames { get; set; }
        public virtual ICollection<StatName> StatNames { get; set; }
        public virtual ICollection<SuperContestEffectProse> SuperContestEffectProses { get; set; }
        public virtual ICollection<TypeName> TypeNames { get; set; }
        public virtual ICollection<VersionName> VersionNames { get; set; }
    }
}
