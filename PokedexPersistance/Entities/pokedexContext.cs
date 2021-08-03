using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class pokedexContext : DbContext
    {
        public pokedexContext()
        {
        }

        public pokedexContext(DbContextOptions<pokedexContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<AbilityChangelog> AbilityChangelogs { get; set; }
        public virtual DbSet<AbilityChangelogProse> AbilityChangelogProses { get; set; }
        public virtual DbSet<AbilityFlavorText> AbilityFlavorTexts { get; set; }
        public virtual DbSet<AbilityName> AbilityNames { get; set; }
        public virtual DbSet<AbilityProse> AbilityProses { get; set; }
        public virtual DbSet<Berry> Berries { get; set; }
        public virtual DbSet<BerryFirmness> BerryFirmnesses { get; set; }
        public virtual DbSet<BerryFirmnessName> BerryFirmnessNames { get; set; }
        public virtual DbSet<BerryFlavor> BerryFlavors { get; set; }
        public virtual DbSet<Characteristic> Characteristics { get; set; }
        public virtual DbSet<CharacteristicText> CharacteristicTexts { get; set; }
        public virtual DbSet<ConquestEpisode> ConquestEpisodes { get; set; }
        public virtual DbSet<ConquestEpisodeName> ConquestEpisodeNames { get; set; }
        public virtual DbSet<ConquestEpisodeWarrior> ConquestEpisodeWarriors { get; set; }
        public virtual DbSet<ConquestKingdom> ConquestKingdoms { get; set; }
        public virtual DbSet<ConquestKingdomName> ConquestKingdomNames { get; set; }
        public virtual DbSet<ConquestMaxLink> ConquestMaxLinks { get; set; }
        public virtual DbSet<ConquestMoveDatum> ConquestMoveData { get; set; }
        public virtual DbSet<ConquestMoveDisplacement> ConquestMoveDisplacements { get; set; }
        public virtual DbSet<ConquestMoveDisplacementProse> ConquestMoveDisplacementProses { get; set; }
        public virtual DbSet<ConquestMoveEffect> ConquestMoveEffects { get; set; }
        public virtual DbSet<ConquestMoveEffectProse> ConquestMoveEffectProses { get; set; }
        public virtual DbSet<ConquestMoveRange> ConquestMoveRanges { get; set; }
        public virtual DbSet<ConquestMoveRangeProse> ConquestMoveRangeProses { get; set; }
        public virtual DbSet<ConquestPokemonAbility> ConquestPokemonAbilities { get; set; }
        public virtual DbSet<ConquestPokemonEvolution> ConquestPokemonEvolutions { get; set; }
        public virtual DbSet<ConquestPokemonMove> ConquestPokemonMoves { get; set; }
        public virtual DbSet<ConquestPokemonStat> ConquestPokemonStats { get; set; }
        public virtual DbSet<ConquestStat> ConquestStats { get; set; }
        public virtual DbSet<ConquestStatName> ConquestStatNames { get; set; }
        public virtual DbSet<ConquestTransformationPokemon> ConquestTransformationPokemons { get; set; }
        public virtual DbSet<ConquestTransformationWarrior> ConquestTransformationWarriors { get; set; }
        public virtual DbSet<ConquestWarrior> ConquestWarriors { get; set; }
        public virtual DbSet<ConquestWarriorArchetype> ConquestWarriorArchetypes { get; set; }
        public virtual DbSet<ConquestWarriorName> ConquestWarriorNames { get; set; }
        public virtual DbSet<ConquestWarriorRank> ConquestWarriorRanks { get; set; }
        public virtual DbSet<ConquestWarriorRankStatMap> ConquestWarriorRankStatMaps { get; set; }
        public virtual DbSet<ConquestWarriorSkill> ConquestWarriorSkills { get; set; }
        public virtual DbSet<ConquestWarriorSkillName> ConquestWarriorSkillNames { get; set; }
        public virtual DbSet<ConquestWarriorSpecialty> ConquestWarriorSpecialties { get; set; }
        public virtual DbSet<ConquestWarriorStat> ConquestWarriorStats { get; set; }
        public virtual DbSet<ConquestWarriorStatName> ConquestWarriorStatNames { get; set; }
        public virtual DbSet<ConquestWarriorTransformation> ConquestWarriorTransformations { get; set; }
        public virtual DbSet<ContestCombo> ContestCombos { get; set; }
        public virtual DbSet<ContestEffect> ContestEffects { get; set; }
        public virtual DbSet<ContestEffectProse> ContestEffectProses { get; set; }
        public virtual DbSet<ContestType> ContestTypes { get; set; }
        public virtual DbSet<ContestTypeName> ContestTypeNames { get; set; }
        public virtual DbSet<EggGroup> EggGroups { get; set; }
        public virtual DbSet<EggGroupProse> EggGroupProses { get; set; }
        public virtual DbSet<Encounter> Encounters { get; set; }
        public virtual DbSet<EncounterCondition> EncounterConditions { get; set; }
        public virtual DbSet<EncounterConditionProse> EncounterConditionProses { get; set; }
        public virtual DbSet<EncounterConditionValue> EncounterConditionValues { get; set; }
        public virtual DbSet<EncounterConditionValueMap> EncounterConditionValueMaps { get; set; }
        public virtual DbSet<EncounterConditionValueProse> EncounterConditionValueProses { get; set; }
        public virtual DbSet<EncounterMethod> EncounterMethods { get; set; }
        public virtual DbSet<EncounterMethodProse> EncounterMethodProses { get; set; }
        public virtual DbSet<EncounterSlot> EncounterSlots { get; set; }
        public virtual DbSet<EvolutionChain> EvolutionChains { get; set; }
        public virtual DbSet<EvolutionTrigger> EvolutionTriggers { get; set; }
        public virtual DbSet<EvolutionTriggerProse> EvolutionTriggerProses { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Generation> Generations { get; set; }
        public virtual DbSet<GenerationName> GenerationNames { get; set; }
        public virtual DbSet<GrowthRate> GrowthRates { get; set; }
        public virtual DbSet<GrowthRateProse> GrowthRateProses { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemCategory> ItemCategories { get; set; }
        public virtual DbSet<ItemCategoryProse> ItemCategoryProses { get; set; }
        public virtual DbSet<ItemFlag> ItemFlags { get; set; }
        public virtual DbSet<ItemFlagMap> ItemFlagMaps { get; set; }
        public virtual DbSet<ItemFlagProse> ItemFlagProses { get; set; }
        public virtual DbSet<ItemFlavorSummary> ItemFlavorSummaries { get; set; }
        public virtual DbSet<ItemFlavorText> ItemFlavorTexts { get; set; }
        public virtual DbSet<ItemFlingEffect> ItemFlingEffects { get; set; }
        public virtual DbSet<ItemFlingEffectProse> ItemFlingEffectProses { get; set; }
        public virtual DbSet<ItemGameIndex> ItemGameIndices { get; set; }
        public virtual DbSet<ItemName> ItemNames { get; set; }
        public virtual DbSet<ItemPocket> ItemPockets { get; set; }
        public virtual DbSet<ItemPocketName> ItemPocketNames { get; set; }
        public virtual DbSet<ItemProse> ItemProses { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LanguageName> LanguageNames { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationArea> LocationAreas { get; set; }
        public virtual DbSet<LocationAreaEncounterRate> LocationAreaEncounterRates { get; set; }
        public virtual DbSet<LocationAreaProse> LocationAreaProses { get; set; }
        public virtual DbSet<LocationGameIndex> LocationGameIndices { get; set; }
        public virtual DbSet<LocationName> LocationNames { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<Move> Moves { get; set; }
        public virtual DbSet<MoveBattleStyle> MoveBattleStyles { get; set; }
        public virtual DbSet<MoveBattleStyleProse> MoveBattleStyleProses { get; set; }
        public virtual DbSet<MoveChangelog> MoveChangelogs { get; set; }
        public virtual DbSet<MoveDamageClass> MoveDamageClasses { get; set; }
        public virtual DbSet<MoveDamageClassProse> MoveDamageClassProses { get; set; }
        public virtual DbSet<MoveEffect> MoveEffects { get; set; }
        public virtual DbSet<MoveEffectChangelog> MoveEffectChangelogs { get; set; }
        public virtual DbSet<MoveEffectChangelogProse> MoveEffectChangelogProses { get; set; }
        public virtual DbSet<MoveEffectProse> MoveEffectProses { get; set; }
        public virtual DbSet<MoveFlag> MoveFlags { get; set; }
        public virtual DbSet<MoveFlagMap> MoveFlagMaps { get; set; }
        public virtual DbSet<MoveFlagProse> MoveFlagProses { get; set; }
        public virtual DbSet<MoveFlavorSummary> MoveFlavorSummaries { get; set; }
        public virtual DbSet<MoveFlavorText> MoveFlavorTexts { get; set; }
        public virtual DbSet<MoveMetaAilment> MoveMetaAilments { get; set; }
        public virtual DbSet<MoveMetaAilmentName> MoveMetaAilmentNames { get; set; }
        public virtual DbSet<MoveMetaCategory> MoveMetaCategories { get; set; }
        public virtual DbSet<MoveMetaCategoryProse> MoveMetaCategoryProses { get; set; }
        public virtual DbSet<MoveMetaStatChange> MoveMetaStatChanges { get; set; }
        public virtual DbSet<MoveMetum> MoveMeta { get; set; }
        public virtual DbSet<MoveName> MoveNames { get; set; }
        public virtual DbSet<MoveTarget> MoveTargets { get; set; }
        public virtual DbSet<MoveTargetProse> MoveTargetProses { get; set; }
        public virtual DbSet<Nature> Natures { get; set; }
        public virtual DbSet<NatureBattleStylePreference> NatureBattleStylePreferences { get; set; }
        public virtual DbSet<NatureName> NatureNames { get; set; }
        public virtual DbSet<NaturePokeathlonStat> NaturePokeathlonStats { get; set; }
        public virtual DbSet<PalPark> PalParks { get; set; }
        public virtual DbSet<PalParkArea> PalParkAreas { get; set; }
        public virtual DbSet<PalParkAreaName> PalParkAreaNames { get; set; }
        public virtual DbSet<PokeathlonStat> PokeathlonStats { get; set; }
        public virtual DbSet<PokeathlonStatName> PokeathlonStatNames { get; set; }
        public virtual DbSet<Pokedex> Pokedexes { get; set; }
        public virtual DbSet<PokedexProse> PokedexProses { get; set; }
        public virtual DbSet<PokedexVersionGroup> PokedexVersionGroups { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<PokemonAbility> PokemonAbilities { get; set; }
        public virtual DbSet<PokemonColor> PokemonColors { get; set; }
        public virtual DbSet<PokemonColorName> PokemonColorNames { get; set; }
        public virtual DbSet<PokemonDexNumber> PokemonDexNumbers { get; set; }
        public virtual DbSet<PokemonEggGroup> PokemonEggGroups { get; set; }
        public virtual DbSet<PokemonEvolution> PokemonEvolutions { get; set; }
        public virtual DbSet<PokemonForm> PokemonForms { get; set; }
        public virtual DbSet<PokemonFormGeneration> PokemonFormGenerations { get; set; }
        public virtual DbSet<PokemonFormName> PokemonFormNames { get; set; }
        public virtual DbSet<PokemonFormPokeathlonStat> PokemonFormPokeathlonStats { get; set; }
        public virtual DbSet<PokemonGameIndex> PokemonGameIndices { get; set; }
        public virtual DbSet<PokemonHabitat> PokemonHabitats { get; set; }
        public virtual DbSet<PokemonHabitatName> PokemonHabitatNames { get; set; }
        public virtual DbSet<PokemonItem> PokemonItems { get; set; }
        public virtual DbSet<PokemonMove> PokemonMoves { get; set; }
        public virtual DbSet<PokemonMoveMethod> PokemonMoveMethods { get; set; }
        public virtual DbSet<PokemonMoveMethodProse> PokemonMoveMethodProses { get; set; }
        public virtual DbSet<PokemonShape> PokemonShapes { get; set; }
        public virtual DbSet<PokemonShapeProse> PokemonShapeProses { get; set; }
        public virtual DbSet<PokemonSpeciesFlavorSummary> PokemonSpeciesFlavorSummaries { get; set; }
        public virtual DbSet<PokemonSpeciesFlavorText> PokemonSpeciesFlavorTexts { get; set; }
        public virtual DbSet<PokemonSpeciesName> PokemonSpeciesNames { get; set; }
        public virtual DbSet<PokemonSpeciesProse> PokemonSpeciesProses { get; set; }
        public virtual DbSet<PokemonSpecy> PokemonSpecies { get; set; }
        public virtual DbSet<PokemonStat> PokemonStats { get; set; }
        public virtual DbSet<PokemonType> PokemonTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RegionName> RegionNames { get; set; }
        public virtual DbSet<Stat> Stats { get; set; }
        public virtual DbSet<StatName> StatNames { get; set; }
        public virtual DbSet<SuperContestCombo> SuperContestCombos { get; set; }
        public virtual DbSet<SuperContestEffect> SuperContestEffects { get; set; }
        public virtual DbSet<SuperContestEffectProse> SuperContestEffectProses { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<TypeEfficacy> TypeEfficacies { get; set; }
        public virtual DbSet<TypeGameIndex> TypeGameIndices { get; set; }
        public virtual DbSet<TypeName> TypeNames { get; set; }
        public virtual DbSet<Version> Versions { get; set; }
        public virtual DbSet<VersionGroup> VersionGroups { get; set; }
        public virtual DbSet<VersionGroupPokemonMoveMethod> VersionGroupPokemonMoveMethods { get; set; }
        public virtual DbSet<VersionGroupRegion> VersionGroupRegions { get; set; }
        public virtual DbSet<VersionName> VersionNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\KC\\Source\\Repos\\PokedexPersistance\\Resources\\pokedex.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.ToTable("abilities");

                entity.HasIndex(e => e.IsMainSeries, "ix_abilities_is_main_series");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IsMainSeries)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_main_series");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.Abilities)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityChangelog>(entity =>
            {
                entity.ToTable("ability_changelog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.ChangedInVersionGroupId).HasColumnName("changed_in_version_group_id");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityChangelogs)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ChangedInVersionGroup)
                    .WithMany(p => p.AbilityChangelogs)
                    .HasForeignKey(d => d.ChangedInVersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityChangelogProse>(entity =>
            {
                entity.HasKey(e => new { e.AbilityChangelogId, e.LocalLanguageId });

                entity.ToTable("ability_changelog_prose");

                entity.Property(e => e.AbilityChangelogId).HasColumnName("ability_changelog_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasColumnName("effect");

                entity.HasOne(d => d.AbilityChangelog)
                    .WithMany(p => p.AbilityChangelogProses)
                    .HasForeignKey(d => d.AbilityChangelogId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.AbilityChangelogProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.AbilityId, e.VersionGroupId, e.LanguageId });

                entity.ToTable("ability_flavor_text");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityFlavorTexts)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AbilityFlavorTexts)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.AbilityFlavorTexts)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityName>(entity =>
            {
                entity.HasKey(e => new { e.AbilityId, e.LocalLanguageId });

                entity.ToTable("ability_names");

                entity.HasIndex(e => e.Name, "ix_ability_names_name");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityNames)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.AbilityNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityProse>(entity =>
            {
                entity.HasKey(e => new { e.AbilityId, e.LocalLanguageId });

                entity.ToTable("ability_prose");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityProses)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.AbilityProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Berry>(entity =>
            {
                entity.ToTable("berries");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FirmnessId).HasColumnName("firmness_id");

                entity.Property(e => e.GrowthTime).HasColumnName("growth_time");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MaxHarvest).HasColumnName("max_harvest");

                entity.Property(e => e.NaturalGiftPower).HasColumnName("natural_gift_power");

                entity.Property(e => e.NaturalGiftTypeId).HasColumnName("natural_gift_type_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Smoothness).HasColumnName("smoothness");

                entity.Property(e => e.SoilDryness).HasColumnName("soil_dryness");

                entity.HasOne(d => d.Firmness)
                    .WithMany(p => p.Berries)
                    .HasForeignKey(d => d.FirmnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Berries)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.NaturalGiftType)
                    .WithMany(p => p.Berries)
                    .HasForeignKey(d => d.NaturalGiftTypeId);
            });

            modelBuilder.Entity<BerryFirmness>(entity =>
            {
                entity.ToTable("berry_firmness");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<BerryFirmnessName>(entity =>
            {
                entity.HasKey(e => new { e.BerryFirmnessId, e.LocalLanguageId });

                entity.ToTable("berry_firmness_names");

                entity.HasIndex(e => e.Name, "ix_berry_firmness_names_name");

                entity.Property(e => e.BerryFirmnessId).HasColumnName("berry_firmness_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.BerryFirmness)
                    .WithMany(p => p.BerryFirmnessNames)
                    .HasForeignKey(d => d.BerryFirmnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.BerryFirmnessNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BerryFlavor>(entity =>
            {
                entity.HasKey(e => new { e.BerryId, e.ContestTypeId });

                entity.ToTable("berry_flavors");

                entity.Property(e => e.BerryId).HasColumnName("berry_id");

                entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");

                entity.Property(e => e.Flavor).HasColumnName("flavor");

                entity.HasOne(d => d.Berry)
                    .WithMany(p => p.BerryFlavors)
                    .HasForeignKey(d => d.BerryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ContestType)
                    .WithMany(p => p.BerryFlavors)
                    .HasForeignKey(d => d.ContestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Characteristic>(entity =>
            {
                entity.ToTable("characteristics");

                entity.HasIndex(e => e.GeneMod5, "ix_characteristics_gene_mod_5");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GeneMod5).HasColumnName("gene_mod_5");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.Characteristics)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CharacteristicText>(entity =>
            {
                entity.HasKey(e => new { e.CharacteristicId, e.LocalLanguageId });

                entity.ToTable("characteristic_text");

                entity.HasIndex(e => e.Message, "ix_characteristic_text_message");

                entity.Property(e => e.CharacteristicId).HasColumnName("characteristic_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("message");

                entity.HasOne(d => d.Characteristic)
                    .WithMany(p => p.CharacteristicTexts)
                    .HasForeignKey(d => d.CharacteristicId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.CharacteristicTexts)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestEpisode>(entity =>
            {
                entity.ToTable("conquest_episodes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ConquestEpisodeName>(entity =>
            {
                entity.HasKey(e => new { e.EpisodeId, e.LocalLanguageId });

                entity.ToTable("conquest_episode_names");

                entity.HasIndex(e => e.Name, "ix_conquest_episode_names_name");

                entity.Property(e => e.EpisodeId).HasColumnName("episode_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.Episode)
                    .WithMany(p => p.ConquestEpisodeNames)
                    .HasForeignKey(d => d.EpisodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestEpisodeNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestEpisodeWarrior>(entity =>
            {
                entity.HasKey(e => new { e.EpisodeId, e.WarriorId });

                entity.ToTable("conquest_episode_warriors");

                entity.Property(e => e.EpisodeId).HasColumnName("episode_id");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.HasOne(d => d.Episode)
                    .WithMany(p => p.ConquestEpisodeWarriors)
                    .HasForeignKey(d => d.EpisodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestEpisodeWarriors)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestKingdom>(entity =>
            {
                entity.ToTable("conquest_kingdoms");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ConquestKingdoms)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestKingdomName>(entity =>
            {
                entity.HasKey(e => new { e.KingdomId, e.LocalLanguageId });

                entity.ToTable("conquest_kingdom_names");

                entity.HasIndex(e => e.Name, "ix_conquest_kingdom_names_name");

                entity.Property(e => e.KingdomId).HasColumnName("kingdom_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.Kingdom)
                    .WithMany(p => p.ConquestKingdomNames)
                    .HasForeignKey(d => d.KingdomId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestKingdomNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMaxLink>(entity =>
            {
                entity.HasKey(e => new { e.WarriorRankId, e.PokemonSpeciesId });

                entity.ToTable("conquest_max_links");

                entity.Property(e => e.WarriorRankId).HasColumnName("warrior_rank_id");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.MaxLink).HasColumnName("max_link");

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestMaxLinks)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WarriorRank)
                    .WithMany(p => p.ConquestMaxLinks)
                    .HasForeignKey(d => d.WarriorRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveDatum>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("conquest_move_data");

                entity.Property(e => e.MoveId)
                    .ValueGeneratedNever()
                    .HasColumnName("move_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.DisplacementId).HasColumnName("displacement_id");

                entity.Property(e => e.EffectChance).HasColumnName("effect_chance");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.Power).HasColumnName("power");

                entity.Property(e => e.RangeId).HasColumnName("range_id");

                entity.HasOne(d => d.Displacement)
                    .WithMany(p => p.ConquestMoveData)
                    .HasForeignKey(d => d.DisplacementId);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.ConquestMoveData)
                    .HasForeignKey(d => d.EffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithOne(p => p.ConquestMoveDatum)
                    .HasForeignKey<ConquestMoveDatum>(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Range)
                    .WithMany(p => p.ConquestMoveData)
                    .HasForeignKey(d => d.RangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveDisplacement>(entity =>
            {
                entity.ToTable("conquest_move_displacements");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AffectsTarget)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("affects_target");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ConquestMoveDisplacementProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveDisplacementId, e.LocalLanguageId });

                entity.ToTable("conquest_move_displacement_prose");

                entity.Property(e => e.MoveDisplacementId).HasColumnName("move_displacement_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestMoveDisplacementProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveDisplacement)
                    .WithMany(p => p.ConquestMoveDisplacementProses)
                    .HasForeignKey(d => d.MoveDisplacementId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveEffect>(entity =>
            {
                entity.ToTable("conquest_move_effects");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ConquestMoveEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.ConquestMoveEffectId, e.LocalLanguageId });

                entity.ToTable("conquest_move_effect_prose");

                entity.Property(e => e.ConquestMoveEffectId).HasColumnName("conquest_move_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.ConquestMoveEffect)
                    .WithMany(p => p.ConquestMoveEffectProses)
                    .HasForeignKey(d => d.ConquestMoveEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestMoveEffectProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveRange>(entity =>
            {
                entity.ToTable("conquest_move_ranges");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.Targets).HasColumnName("targets");
            });

            modelBuilder.Entity<ConquestMoveRangeProse>(entity =>
            {
                entity.HasKey(e => new { e.ConquestMoveRangeId, e.LocalLanguageId });

                entity.ToTable("conquest_move_range_prose");

                entity.Property(e => e.ConquestMoveRangeId).HasColumnName("conquest_move_range_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.ConquestMoveRange)
                    .WithMany(p => p.ConquestMoveRangeProses)
                    .HasForeignKey(d => d.ConquestMoveRangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestMoveRangeProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestPokemonAbility>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.Slot });

                entity.ToTable("conquest_pokemon_abilities");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.ConquestPokemonAbilities)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestPokemonAbilities)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestPokemonEvolution>(entity =>
            {
                entity.HasKey(e => e.EvolvedSpeciesId);

                entity.ToTable("conquest_pokemon_evolution");

                entity.Property(e => e.EvolvedSpeciesId)
                    .ValueGeneratedNever()
                    .HasColumnName("evolved_species_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.KingdomId).HasColumnName("kingdom_id");

                entity.Property(e => e.MinimumLink).HasColumnName("minimum_link");

                entity.Property(e => e.MinimumStat).HasColumnName("minimum_stat");

                entity.Property(e => e.RecruitingKoRequired)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("recruiting_ko_required");

                entity.Property(e => e.RequiredStatId).HasColumnName("required_stat_id");

                entity.Property(e => e.WarriorGenderId).HasColumnName("warrior_gender_id");

                entity.HasOne(d => d.EvolvedSpecies)
                    .WithOne(p => p.ConquestPokemonEvolution)
                    .HasForeignKey<ConquestPokemonEvolution>(d => d.EvolvedSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ConquestPokemonEvolutions)
                    .HasForeignKey(d => d.ItemId);

                entity.HasOne(d => d.Kingdom)
                    .WithMany(p => p.ConquestPokemonEvolutions)
                    .HasForeignKey(d => d.KingdomId);

                entity.HasOne(d => d.RequiredStat)
                    .WithMany(p => p.ConquestPokemonEvolutions)
                    .HasForeignKey(d => d.RequiredStatId);

                entity.HasOne(d => d.WarriorGender)
                    .WithMany(p => p.ConquestPokemonEvolutions)
                    .HasForeignKey(d => d.WarriorGenderId);
            });

            modelBuilder.Entity<ConquestPokemonMove>(entity =>
            {
                entity.HasKey(e => e.PokemonSpeciesId);

                entity.ToTable("conquest_pokemon_moves");

                entity.Property(e => e.PokemonSpeciesId)
                    .ValueGeneratedNever()
                    .HasColumnName("pokemon_species_id");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.ConquestPokemonMoves)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithOne(p => p.ConquestPokemonMove)
                    .HasForeignKey<ConquestPokemonMove>(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestPokemonStat>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.ConquestStatId });

                entity.ToTable("conquest_pokemon_stats");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.ConquestStatId).HasColumnName("conquest_stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.HasOne(d => d.ConquestStat)
                    .WithMany(p => p.ConquestPokemonStats)
                    .HasForeignKey(d => d.ConquestStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestPokemonStats)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestStat>(entity =>
            {
                entity.ToTable("conquest_stats");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IsBase)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_base");
            });

            modelBuilder.Entity<ConquestStatName>(entity =>
            {
                entity.HasKey(e => new { e.ConquestStatId, e.LocalLanguageId });

                entity.ToTable("conquest_stat_names");

                entity.HasIndex(e => e.Name, "ix_conquest_stat_names_name");

                entity.Property(e => e.ConquestStatId).HasColumnName("conquest_stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.ConquestStat)
                    .WithMany(p => p.ConquestStatNames)
                    .HasForeignKey(d => d.ConquestStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestStatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestTransformationPokemon>(entity =>
            {
                entity.HasKey(e => new { e.TransformationId, e.PokemonSpeciesId });

                entity.ToTable("conquest_transformation_pokemon");

                entity.Property(e => e.TransformationId).HasColumnName("transformation_id");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestTransformationPokemons)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Transformation)
                    .WithMany(p => p.ConquestTransformationPokemons)
                    .HasForeignKey(d => d.TransformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestTransformationWarrior>(entity =>
            {
                entity.HasKey(e => new { e.TransformationId, e.PresentWarriorId });

                entity.ToTable("conquest_transformation_warriors");

                entity.Property(e => e.TransformationId).HasColumnName("transformation_id");

                entity.Property(e => e.PresentWarriorId).HasColumnName("present_warrior_id");

                entity.HasOne(d => d.PresentWarrior)
                    .WithMany(p => p.ConquestTransformationWarriors)
                    .HasForeignKey(d => d.PresentWarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Transformation)
                    .WithMany(p => p.ConquestTransformationWarriors)
                    .HasForeignKey(d => d.TransformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarrior>(entity =>
            {
                entity.ToTable("conquest_warriors");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ArchetypeId).HasColumnName("archetype_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.HasOne(d => d.Archetype)
                    .WithMany(p => p.ConquestWarriors)
                    .HasForeignKey(d => d.ArchetypeId);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.ConquestWarriors)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorArchetype>(entity =>
            {
                entity.ToTable("conquest_warrior_archetypes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ConquestWarriorName>(entity =>
            {
                entity.HasKey(e => new { e.WarriorId, e.LocalLanguageId });

                entity.ToTable("conquest_warrior_names");

                entity.HasIndex(e => e.Name, "ix_conquest_warrior_names_name");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestWarriorNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestWarriorNames)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorRank>(entity =>
            {
                entity.ToTable("conquest_warrior_ranks");

                entity.HasIndex(e => new { e.WarriorId, e.Rank }, "IX_conquest_warrior_ranks_warrior_id_rank")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ConquestWarriorRanks)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestWarriorRanks)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorRankStatMap>(entity =>
            {
                entity.HasKey(e => new { e.WarriorRankId, e.WarriorStatId });

                entity.ToTable("conquest_warrior_rank_stat_map");

                entity.Property(e => e.WarriorRankId).HasColumnName("warrior_rank_id");

                entity.Property(e => e.WarriorStatId).HasColumnName("warrior_stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.HasOne(d => d.WarriorRank)
                    .WithMany(p => p.ConquestWarriorRankStatMaps)
                    .HasForeignKey(d => d.WarriorRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WarriorStat)
                    .WithMany(p => p.ConquestWarriorRankStatMaps)
                    .HasForeignKey(d => d.WarriorStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorSkill>(entity =>
            {
                entity.ToTable("conquest_warrior_skills");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ConquestWarriorSkillName>(entity =>
            {
                entity.HasKey(e => new { e.SkillId, e.LocalLanguageId });

                entity.ToTable("conquest_warrior_skill_names");

                entity.HasIndex(e => e.Name, "ix_conquest_warrior_skill_names_name");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestWarriorSkillNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ConquestWarriorSkillNames)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorSpecialty>(entity =>
            {
                entity.HasKey(e => new { e.WarriorId, e.TypeId, e.Slot });

                entity.ToTable("conquest_warrior_specialties");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ConquestWarriorSpecialties)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestWarriorSpecialties)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorStat>(entity =>
            {
                entity.ToTable("conquest_warrior_stats");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ConquestWarriorStatName>(entity =>
            {
                entity.HasKey(e => new { e.WarriorStatId, e.LocalLanguageId });

                entity.ToTable("conquest_warrior_stat_names");

                entity.HasIndex(e => e.Name, "ix_conquest_warrior_stat_names_name");

                entity.Property(e => e.WarriorStatId).HasColumnName("warrior_stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestWarriorStatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WarriorStat)
                    .WithMany(p => p.ConquestWarriorStatNames)
                    .HasForeignKey(d => d.WarriorStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorTransformation>(entity =>
            {
                entity.HasKey(e => e.TransformedWarriorRankId);

                entity.ToTable("conquest_warrior_transformation");

                entity.Property(e => e.TransformedWarriorRankId)
                    .ValueGeneratedNever()
                    .HasColumnName("transformed_warrior_rank_id");

                entity.Property(e => e.CollectionTypeId).HasColumnName("collection_type_id");

                entity.Property(e => e.CompletedEpisodeId).HasColumnName("completed_episode_id");

                entity.Property(e => e.CurrentEpisodeId).HasColumnName("current_episode_id");

                entity.Property(e => e.DistantWarriorId).HasColumnName("distant_warrior_id");

                entity.Property(e => e.FemaleWarlordCount).HasColumnName("female_warlord_count");

                entity.Property(e => e.IsAutomatic)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_automatic");

                entity.Property(e => e.PokemonCount).HasColumnName("pokemon_count");

                entity.Property(e => e.RequiredLink).HasColumnName("required_link");

                entity.Property(e => e.WarriorCount).HasColumnName("warrior_count");

                entity.HasOne(d => d.CollectionType)
                    .WithMany(p => p.ConquestWarriorTransformations)
                    .HasForeignKey(d => d.CollectionTypeId);

                entity.HasOne(d => d.CompletedEpisode)
                    .WithMany(p => p.ConquestWarriorTransformationCompletedEpisodes)
                    .HasForeignKey(d => d.CompletedEpisodeId);

                entity.HasOne(d => d.CurrentEpisode)
                    .WithMany(p => p.ConquestWarriorTransformationCurrentEpisodes)
                    .HasForeignKey(d => d.CurrentEpisodeId);

                entity.HasOne(d => d.DistantWarrior)
                    .WithMany(p => p.ConquestWarriorTransformations)
                    .HasForeignKey(d => d.DistantWarriorId);

                entity.HasOne(d => d.TransformedWarriorRank)
                    .WithOne(p => p.ConquestWarriorTransformation)
                    .HasForeignKey<ConquestWarriorTransformation>(d => d.TransformedWarriorRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContestCombo>(entity =>
            {
                entity.HasKey(e => new { e.FirstMoveId, e.SecondMoveId });

                entity.ToTable("contest_combos");

                entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");

                entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

                entity.HasOne(d => d.FirstMove)
                    .WithMany(p => p.ContestComboFirstMoves)
                    .HasForeignKey(d => d.FirstMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SecondMove)
                    .WithMany(p => p.ContestComboSecondMoves)
                    .HasForeignKey(d => d.SecondMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContestEffect>(entity =>
            {
                entity.ToTable("contest_effects");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Appeal)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("appeal");

                entity.Property(e => e.Jam)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("jam");
            });

            modelBuilder.Entity<ContestEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.ContestEffectId, e.LocalLanguageId });

                entity.ToTable("contest_effect_prose");

                entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.FlavorText).HasColumnName("flavor_text");

                entity.HasOne(d => d.ContestEffect)
                    .WithMany(p => p.ContestEffectProses)
                    .HasForeignKey(d => d.ContestEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ContestEffectProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContestType>(entity =>
            {
                entity.ToTable("contest_types");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ContestTypeName>(entity =>
            {
                entity.HasKey(e => new { e.ContestTypeId, e.LocalLanguageId });

                entity.ToTable("contest_type_names");

                entity.HasIndex(e => e.Name, "ix_contest_type_names_name");

                entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.Flavor).HasColumnName("flavor");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.ContestType)
                    .WithMany(p => p.ContestTypeNames)
                    .HasForeignKey(d => d.ContestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ContestTypeNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EggGroup>(entity =>
            {
                entity.ToTable("egg_groups");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<EggGroupProse>(entity =>
            {
                entity.HasKey(e => new { e.EggGroupId, e.LocalLanguageId });

                entity.ToTable("egg_group_prose");

                entity.HasIndex(e => e.Name, "ix_egg_group_prose_name");

                entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.EggGroup)
                    .WithMany(p => p.EggGroupProses)
                    .HasForeignKey(d => d.EggGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EggGroupProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Encounter>(entity =>
            {
                entity.ToTable("encounters");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EncounterSlotId).HasColumnName("encounter_slot_id");

                entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.HasOne(d => d.EncounterSlot)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.EncounterSlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocationArea)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.LocationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterCondition>(entity =>
            {
                entity.ToTable("encounter_conditions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<EncounterConditionProse>(entity =>
            {
                entity.HasKey(e => new { e.EncounterConditionId, e.LocalLanguageId });

                entity.ToTable("encounter_condition_prose");

                entity.HasIndex(e => e.Name, "ix_encounter_condition_prose_name");

                entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.EncounterCondition)
                    .WithMany(p => p.EncounterConditionProses)
                    .HasForeignKey(d => d.EncounterConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EncounterConditionProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterConditionValue>(entity =>
            {
                entity.ToTable("encounter_condition_values");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_default");

                entity.HasOne(d => d.EncounterCondition)
                    .WithMany(p => p.EncounterConditionValues)
                    .HasForeignKey(d => d.EncounterConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterConditionValueMap>(entity =>
            {
                entity.HasKey(e => new { e.EncounterId, e.EncounterConditionValueId });

                entity.ToTable("encounter_condition_value_map");

                entity.Property(e => e.EncounterId).HasColumnName("encounter_id");

                entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");

                entity.HasOne(d => d.EncounterConditionValue)
                    .WithMany(p => p.EncounterConditionValueMaps)
                    .HasForeignKey(d => d.EncounterConditionValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Encounter)
                    .WithMany(p => p.EncounterConditionValueMaps)
                    .HasForeignKey(d => d.EncounterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterConditionValueProse>(entity =>
            {
                entity.HasKey(e => new { e.EncounterConditionValueId, e.LocalLanguageId });

                entity.ToTable("encounter_condition_value_prose");

                entity.HasIndex(e => e.Name, "ix_encounter_condition_value_prose_name");

                entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.EncounterConditionValue)
                    .WithMany(p => p.EncounterConditionValueProses)
                    .HasForeignKey(d => d.EncounterConditionValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EncounterConditionValueProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterMethod>(entity =>
            {
                entity.ToTable("encounter_methods");

                entity.HasIndex(e => e.Identifier, "IX_encounter_methods_identifier")
                    .IsUnique();

                entity.HasIndex(e => e.Order, "IX_encounter_methods_order")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<EncounterMethodProse>(entity =>
            {
                entity.HasKey(e => new { e.EncounterMethodId, e.LocalLanguageId });

                entity.ToTable("encounter_method_prose");

                entity.HasIndex(e => e.Name, "ix_encounter_method_prose_name");

                entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.EncounterMethod)
                    .WithMany(p => p.EncounterMethodProses)
                    .HasForeignKey(d => d.EncounterMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EncounterMethodProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterSlot>(entity =>
            {
                entity.ToTable("encounter_slots");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.HasOne(d => d.EncounterMethod)
                    .WithMany(p => p.EncounterSlots)
                    .HasForeignKey(d => d.EncounterMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.EncounterSlots)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EvolutionChain>(entity =>
            {
                entity.ToTable("evolution_chains");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BabyTriggerItemId).HasColumnName("baby_trigger_item_id");

                entity.HasOne(d => d.BabyTriggerItem)
                    .WithMany(p => p.EvolutionChains)
                    .HasForeignKey(d => d.BabyTriggerItemId);
            });

            modelBuilder.Entity<EvolutionTrigger>(entity =>
            {
                entity.ToTable("evolution_triggers");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<EvolutionTriggerProse>(entity =>
            {
                entity.HasKey(e => new { e.EvolutionTriggerId, e.LocalLanguageId });

                entity.ToTable("evolution_trigger_prose");

                entity.HasIndex(e => e.Name, "ix_evolution_trigger_prose_name");

                entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.EvolutionTrigger)
                    .WithMany(p => p.EvolutionTriggerProses)
                    .HasForeignKey(d => d.EvolutionTriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EvolutionTriggerProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.HasKey(e => new { e.GrowthRateId, e.Level });

                entity.ToTable("experience");

                entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Experience1).HasColumnName("experience");

                entity.HasOne(d => d.GrowthRate)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.GrowthRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("genders");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<Generation>(entity =>
            {
                entity.ToTable("generations");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.MainRegionId).HasColumnName("main_region_id");

                entity.HasOne(d => d.MainRegion)
                    .WithMany(p => p.Generations)
                    .HasForeignKey(d => d.MainRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<GenerationName>(entity =>
            {
                entity.HasKey(e => new { e.GenerationId, e.LocalLanguageId });

                entity.ToTable("generation_names");

                entity.HasIndex(e => e.Name, "ix_generation_names_name");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.GenerationNames)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.GenerationNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<GrowthRate>(entity =>
            {
                entity.ToTable("growth_rates");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasColumnName("formula");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<GrowthRateProse>(entity =>
            {
                entity.HasKey(e => new { e.GrowthRateId, e.LocalLanguageId });

                entity.ToTable("growth_rate_prose");

                entity.HasIndex(e => e.Name, "ix_growth_rate_prose_name");

                entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.GrowthRate)
                    .WithMany(p => p.GrowthRateProses)
                    .HasForeignKey(d => d.GrowthRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.GrowthRateProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("items");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.FlingEffectId).HasColumnName("fling_effect_id");

                entity.Property(e => e.FlingPower).HasColumnName("fling_power");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FlingEffect)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.FlingEffectId);
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.ToTable("item_categories");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.PocketId).HasColumnName("pocket_id");

                entity.HasOne(d => d.Pocket)
                    .WithMany(p => p.ItemCategories)
                    .HasForeignKey(d => d.PocketId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemCategoryProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemCategoryId, e.LocalLanguageId });

                entity.ToTable("item_category_prose");

                entity.HasIndex(e => e.Name, "ix_item_category_prose_name");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.ItemCategoryProses)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemCategoryProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlag>(entity =>
            {
                entity.ToTable("item_flags");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ItemFlagMap>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ItemFlagId });

                entity.ToTable("item_flag_map");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemFlagId).HasColumnName("item_flag_id");

                entity.HasOne(d => d.ItemFlag)
                    .WithMany(p => p.ItemFlagMaps)
                    .HasForeignKey(d => d.ItemFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemFlagMaps)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlagProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemFlagId, e.LocalLanguageId });

                entity.ToTable("item_flag_prose");

                entity.HasIndex(e => e.Name, "ix_item_flag_prose_name");

                entity.Property(e => e.ItemFlagId).HasColumnName("item_flag_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.ItemFlag)
                    .WithMany(p => p.ItemFlagProses)
                    .HasForeignKey(d => d.ItemFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemFlagProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlavorSummary>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.LocalLanguageId });

                entity.ToTable("item_flavor_summaries");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorSummary).HasColumnName("flavor_summary");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemFlavorSummaries)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemFlavorSummaries)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.VersionGroupId, e.LanguageId });

                entity.ToTable("item_flavor_text");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemFlavorTexts)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ItemFlavorTexts)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.ItemFlavorTexts)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlingEffect>(entity =>
            {
                entity.ToTable("item_fling_effects");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ItemFlingEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemFlingEffectId, e.LocalLanguageId });

                entity.ToTable("item_fling_effect_prose");

                entity.Property(e => e.ItemFlingEffectId).HasColumnName("item_fling_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasColumnName("effect");

                entity.HasOne(d => d.ItemFlingEffect)
                    .WithMany(p => p.ItemFlingEffectProses)
                    .HasForeignKey(d => d.ItemFlingEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemFlingEffectProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemGameIndex>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.GenerationId });

                entity.ToTable("item_game_indices");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.ItemGameIndices)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemGameIndices)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemName>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.LocalLanguageId });

                entity.ToTable("item_names");

                entity.HasIndex(e => e.Name, "ix_item_names_name");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemNames)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemPocket>(entity =>
            {
                entity.ToTable("item_pockets");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<ItemPocketName>(entity =>
            {
                entity.HasKey(e => new { e.ItemPocketId, e.LocalLanguageId });

                entity.ToTable("item_pocket_names");

                entity.HasIndex(e => e.Name, "ix_item_pocket_names_name");

                entity.Property(e => e.ItemPocketId).HasColumnName("item_pocket_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.ItemPocket)
                    .WithMany(p => p.ItemPocketNames)
                    .HasForeignKey(d => d.ItemPocketId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemPocketNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.LocalLanguageId });

                entity.ToTable("item_prose");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemProses)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("languages");

                entity.HasIndex(e => e.Official, "ix_languages_official");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.Iso3166)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("iso3166");

                entity.Property(e => e.Iso639)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("iso639");

                entity.Property(e => e.Official)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("official");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<LanguageName>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.LocalLanguageId });

                entity.ToTable("language_names");

                entity.HasIndex(e => e.Name, "ix_language_names_name");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguageNameLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.LanguageNameLocalLanguages)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("locations");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<LocationArea>(entity =>
            {
                entity.ToTable("location_areas");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.Property(e => e.Identifier)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationAreas)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationAreaEncounterRate>(entity =>
            {
                entity.HasKey(e => new { e.LocationAreaId, e.EncounterMethodId, e.VersionId });

                entity.ToTable("location_area_encounter_rates");

                entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");

                entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.HasOne(d => d.EncounterMethod)
                    .WithMany(p => p.LocationAreaEncounterRates)
                    .HasForeignKey(d => d.EncounterMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocationArea)
                    .WithMany(p => p.LocationAreaEncounterRates)
                    .HasForeignKey(d => d.LocationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.LocationAreaEncounterRates)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationAreaProse>(entity =>
            {
                entity.HasKey(e => new { e.LocationAreaId, e.LocalLanguageId });

                entity.ToTable("location_area_prose");

                entity.HasIndex(e => e.Name, "ix_location_area_prose_name");

                entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.LocationAreaProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocationArea)
                    .WithMany(p => p.LocationAreaProses)
                    .HasForeignKey(d => d.LocationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationGameIndex>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.GenerationId, e.GameIndex });

                entity.ToTable("location_game_indices");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.LocationGameIndices)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationGameIndices)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationName>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.LocalLanguageId });

                entity.ToTable("location_names");

                entity.HasIndex(e => e.Name, "ix_location_names_name");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.LocationNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationNames)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => new { e.MachineNumber, e.VersionGroupId });

                entity.ToTable("machines");

                entity.Property(e => e.MachineNumber).HasColumnName("machine_number");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Move>(entity =>
            {
                entity.ToTable("moves");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Accuracy)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("accuracy");

                entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");

                entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");

                entity.Property(e => e.DamageClassId).HasColumnName("damage_class_id");

                entity.Property(e => e.EffectChance).HasColumnName("effect_chance");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.Power)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("power");

                entity.Property(e => e.Pp)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("pp");

                entity.Property(e => e.Priority)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("priority");

                entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.ContestEffect)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.ContestEffectId);

                entity.HasOne(d => d.ContestType)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.ContestTypeId);

                entity.HasOne(d => d.DamageClass)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.DamageClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.EffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SuperContestEffect)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.SuperContestEffectId);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.TargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveBattleStyle>(entity =>
            {
                entity.ToTable("move_battle_styles");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<MoveBattleStyleProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveBattleStyleId, e.LocalLanguageId });

                entity.ToTable("move_battle_style_prose");

                entity.HasIndex(e => e.Name, "ix_move_battle_style_prose_name");

                entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveBattleStyleProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveBattleStyle)
                    .WithMany(p => p.MoveBattleStyleProses)
                    .HasForeignKey(d => d.MoveBattleStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveChangelog>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.ChangedInVersionGroupId });

                entity.ToTable("move_changelog");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.ChangedInVersionGroupId).HasColumnName("changed_in_version_group_id");

                entity.Property(e => e.Accuracy)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("accuracy");

                entity.Property(e => e.EffectChance).HasColumnName("effect_chance");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.Power)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("power");

                entity.Property(e => e.Pp)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("pp");

                entity.Property(e => e.Priority)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("priority");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.ChangedInVersionGroup)
                    .WithMany(p => p.MoveChangelogs)
                    .HasForeignKey(d => d.ChangedInVersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.MoveChangelogs)
                    .HasForeignKey(d => d.EffectId);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveChangelogs)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.MoveChangelogs)
                    .HasForeignKey(d => d.TargetId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MoveChangelogs)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<MoveDamageClass>(entity =>
            {
                entity.ToTable("move_damage_classes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<MoveDamageClassProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveDamageClassId, e.LocalLanguageId });

                entity.ToTable("move_damage_class_prose");

                entity.HasIndex(e => e.Name, "ix_move_damage_class_prose_name");

                entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveDamageClassProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveDamageClass)
                    .WithMany(p => p.MoveDamageClassProses)
                    .HasForeignKey(d => d.MoveDamageClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveEffect>(entity =>
            {
                entity.ToTable("move_effects");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<MoveEffectChangelog>(entity =>
            {
                entity.ToTable("move_effect_changelog");

                entity.HasIndex(e => new { e.EffectId, e.ChangedInVersionGroupId }, "IX_move_effect_changelog_effect_id_changed_in_version_group_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ChangedInVersionGroupId).HasColumnName("changed_in_version_group_id");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.HasOne(d => d.ChangedInVersionGroup)
                    .WithMany(p => p.MoveEffectChangelogs)
                    .HasForeignKey(d => d.ChangedInVersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.MoveEffectChangelogs)
                    .HasForeignKey(d => d.EffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveEffectChangelogProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveEffectChangelogId, e.LocalLanguageId });

                entity.ToTable("move_effect_changelog_prose");

                entity.Property(e => e.MoveEffectChangelogId).HasColumnName("move_effect_changelog_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasColumnName("effect");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveEffectChangelogProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveEffectChangelog)
                    .WithMany(p => p.MoveEffectChangelogProses)
                    .HasForeignKey(d => d.MoveEffectChangelogId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveEffectId, e.LocalLanguageId });

                entity.ToTable("move_effect_prose");

                entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveEffectProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveEffect)
                    .WithMany(p => p.MoveEffectProses)
                    .HasForeignKey(d => d.MoveEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveFlag>(entity =>
            {
                entity.ToTable("move_flags");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<MoveFlagMap>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.MoveFlagId });

                entity.ToTable("move_flag_map");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.MoveFlagId).HasColumnName("move_flag_id");

                entity.HasOne(d => d.MoveFlag)
                    .WithMany(p => p.MoveFlagMaps)
                    .HasForeignKey(d => d.MoveFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveFlagMaps)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveFlagProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveFlagId, e.LocalLanguageId });

                entity.ToTable("move_flag_prose");

                entity.HasIndex(e => e.Name, "ix_move_flag_prose_name");

                entity.Property(e => e.MoveFlagId).HasColumnName("move_flag_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveFlagProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveFlag)
                    .WithMany(p => p.MoveFlagProses)
                    .HasForeignKey(d => d.MoveFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveFlavorSummary>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.LocalLanguageId });

                entity.ToTable("move_flavor_summaries");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorSummary).HasColumnName("flavor_summary");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveFlavorSummaries)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveFlavorSummaries)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.VersionGroupId, e.LanguageId });

                entity.ToTable("move_flavor_text");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.MoveFlavorTexts)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveFlavorTexts)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.MoveFlavorTexts)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMetaAilment>(entity =>
            {
                entity.ToTable("move_meta_ailments");

                entity.HasIndex(e => e.Identifier, "ix_move_meta_ailments_identifier")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<MoveMetaAilmentName>(entity =>
            {
                entity.HasKey(e => new { e.MoveMetaAilmentId, e.LocalLanguageId });

                entity.ToTable("move_meta_ailment_names");

                entity.HasIndex(e => e.Name, "ix_move_meta_ailment_names_name");

                entity.Property(e => e.MoveMetaAilmentId).HasColumnName("move_meta_ailment_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveMetaAilmentNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveMetaAilment)
                    .WithMany(p => p.MoveMetaAilmentNames)
                    .HasForeignKey(d => d.MoveMetaAilmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMetaCategory>(entity =>
            {
                entity.ToTable("move_meta_categories");

                entity.HasIndex(e => e.Identifier, "ix_move_meta_categories_identifier")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<MoveMetaCategoryProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveMetaCategoryId, e.LocalLanguageId });

                entity.ToTable("move_meta_category_prose");

                entity.Property(e => e.MoveMetaCategoryId).HasColumnName("move_meta_category_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveMetaCategoryProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveMetaCategory)
                    .WithMany(p => p.MoveMetaCategoryProses)
                    .HasForeignKey(d => d.MoveMetaCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMetaStatChange>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.StatId });

                entity.ToTable("move_meta_stat_changes");

                entity.HasIndex(e => e.Change, "ix_move_meta_stat_changes_change");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.Property(e => e.Change).HasColumnName("change");

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveMetaStatChanges)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.MoveMetaStatChanges)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMetum>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("move_meta");

                entity.HasIndex(e => e.AilmentChance, "ix_move_meta_ailment_chance");

                entity.HasIndex(e => e.CritRate, "ix_move_meta_crit_rate");

                entity.HasIndex(e => e.Drain, "ix_move_meta_drain");

                entity.HasIndex(e => e.FlinchChance, "ix_move_meta_flinch_chance");

                entity.HasIndex(e => e.Healing, "ix_move_meta_healing");

                entity.HasIndex(e => e.MaxHits, "ix_move_meta_max_hits");

                entity.HasIndex(e => e.MaxTurns, "ix_move_meta_max_turns");

                entity.HasIndex(e => e.MinHits, "ix_move_meta_min_hits");

                entity.HasIndex(e => e.MinTurns, "ix_move_meta_min_turns");

                entity.HasIndex(e => e.StatChance, "ix_move_meta_stat_chance");

                entity.Property(e => e.MoveId)
                    .ValueGeneratedNever()
                    .HasColumnName("move_id");

                entity.Property(e => e.AilmentChance).HasColumnName("ailment_chance");

                entity.Property(e => e.CritRate).HasColumnName("crit_rate");

                entity.Property(e => e.Drain).HasColumnName("drain");

                entity.Property(e => e.FlinchChance).HasColumnName("flinch_chance");

                entity.Property(e => e.Healing).HasColumnName("healing");

                entity.Property(e => e.MaxHits).HasColumnName("max_hits");

                entity.Property(e => e.MaxTurns).HasColumnName("max_turns");

                entity.Property(e => e.MetaAilmentId).HasColumnName("meta_ailment_id");

                entity.Property(e => e.MetaCategoryId).HasColumnName("meta_category_id");

                entity.Property(e => e.MinHits).HasColumnName("min_hits");

                entity.Property(e => e.MinTurns).HasColumnName("min_turns");

                entity.Property(e => e.StatChance).HasColumnName("stat_chance");

                entity.HasOne(d => d.MetaAilment)
                    .WithMany(p => p.MoveMeta)
                    .HasForeignKey(d => d.MetaAilmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MetaCategory)
                    .WithMany(p => p.MoveMeta)
                    .HasForeignKey(d => d.MetaCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithOne(p => p.MoveMetum)
                    .HasForeignKey<MoveMetum>(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveName>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.LocalLanguageId });

                entity.ToTable("move_names");

                entity.HasIndex(e => e.Name, "ix_move_names_name");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveNames)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveTarget>(entity =>
            {
                entity.ToTable("move_targets");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<MoveTargetProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveTargetId, e.LocalLanguageId });

                entity.ToTable("move_target_prose");

                entity.HasIndex(e => e.Name, "ix_move_target_prose_name");

                entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveTargetProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveTarget)
                    .WithMany(p => p.MoveTargetProses)
                    .HasForeignKey(d => d.MoveTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Nature>(entity =>
            {
                entity.ToTable("natures");

                entity.HasIndex(e => e.GameIndex, "IX_natures_game_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DecreasedStatId).HasColumnName("decreased_stat_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.Property(e => e.HatesFlavorId).HasColumnName("hates_flavor_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IncreasedStatId).HasColumnName("increased_stat_id");

                entity.Property(e => e.LikesFlavorId).HasColumnName("likes_flavor_id");

                entity.HasOne(d => d.DecreasedStat)
                    .WithMany(p => p.NatureDecreasedStats)
                    .HasForeignKey(d => d.DecreasedStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.HatesFlavor)
                    .WithMany(p => p.NatureHatesFlavors)
                    .HasForeignKey(d => d.HatesFlavorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IncreasedStat)
                    .WithMany(p => p.NatureIncreasedStats)
                    .HasForeignKey(d => d.IncreasedStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LikesFlavor)
                    .WithMany(p => p.NatureLikesFlavors)
                    .HasForeignKey(d => d.LikesFlavorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NatureBattleStylePreference>(entity =>
            {
                entity.HasKey(e => new { e.NatureId, e.MoveBattleStyleId });

                entity.ToTable("nature_battle_style_preferences");

                entity.Property(e => e.NatureId).HasColumnName("nature_id");

                entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");

                entity.Property(e => e.HighHpPreference).HasColumnName("high_hp_preference");

                entity.Property(e => e.LowHpPreference).HasColumnName("low_hp_preference");

                entity.HasOne(d => d.MoveBattleStyle)
                    .WithMany(p => p.NatureBattleStylePreferences)
                    .HasForeignKey(d => d.MoveBattleStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.NatureBattleStylePreferences)
                    .HasForeignKey(d => d.NatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NatureName>(entity =>
            {
                entity.HasKey(e => new { e.NatureId, e.LocalLanguageId });

                entity.ToTable("nature_names");

                entity.HasIndex(e => e.Name, "ix_nature_names_name");

                entity.Property(e => e.NatureId).HasColumnName("nature_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.NatureNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.NatureNames)
                    .HasForeignKey(d => d.NatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NaturePokeathlonStat>(entity =>
            {
                entity.HasKey(e => new { e.NatureId, e.PokeathlonStatId });

                entity.ToTable("nature_pokeathlon_stats");

                entity.Property(e => e.NatureId).HasColumnName("nature_id");

                entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

                entity.Property(e => e.MaxChange).HasColumnName("max_change");

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.NaturePokeathlonStats)
                    .HasForeignKey(d => d.NatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokeathlonStat)
                    .WithMany(p => p.NaturePokeathlonStats)
                    .HasForeignKey(d => d.PokeathlonStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PalPark>(entity =>
            {
                entity.HasKey(e => e.SpeciesId);

                entity.ToTable("pal_park");

                entity.Property(e => e.SpeciesId)
                    .ValueGeneratedNever()
                    .HasColumnName("species_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BaseScore).HasColumnName("base_score");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.PalParks)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithOne(p => p.PalPark)
                    .HasForeignKey<PalPark>(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PalParkArea>(entity =>
            {
                entity.ToTable("pal_park_areas");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<PalParkAreaName>(entity =>
            {
                entity.HasKey(e => new { e.PalParkAreaId, e.LocalLanguageId });

                entity.ToTable("pal_park_area_names");

                entity.HasIndex(e => e.Name, "ix_pal_park_area_names_name");

                entity.Property(e => e.PalParkAreaId).HasColumnName("pal_park_area_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PalParkAreaNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PalParkArea)
                    .WithMany(p => p.PalParkAreaNames)
                    .HasForeignKey(d => d.PalParkAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokeathlonStat>(entity =>
            {
                entity.ToTable("pokeathlon_stats");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<PokeathlonStatName>(entity =>
            {
                entity.HasKey(e => new { e.PokeathlonStatId, e.LocalLanguageId });

                entity.ToTable("pokeathlon_stat_names");

                entity.HasIndex(e => e.Name, "ix_pokeathlon_stat_names_name");

                entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokeathlonStatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokeathlonStat)
                    .WithMany(p => p.PokeathlonStatNames)
                    .HasForeignKey(d => d.PokeathlonStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Pokedex>(entity =>
            {
                entity.ToTable("pokedexes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IsMainSeries)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_main_series");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Pokedices)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<PokedexProse>(entity =>
            {
                entity.HasKey(e => new { e.PokedexId, e.LocalLanguageId });

                entity.ToTable("pokedex_prose");

                entity.HasIndex(e => e.Name, "ix_pokedex_prose_name");

                entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokedexProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokedex)
                    .WithMany(p => p.PokedexProses)
                    .HasForeignKey(d => d.PokedexId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokedexVersionGroup>(entity =>
            {
                entity.HasKey(e => new { e.PokedexId, e.VersionGroupId });

                entity.ToTable("pokedex_version_groups");

                entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.HasOne(d => d.Pokedex)
                    .WithMany(p => p.PokedexVersionGroups)
                    .HasForeignKey(d => d.PokedexId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.PokedexVersionGroups)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.ToTable("pokemon");

                entity.HasIndex(e => e.IsDefault, "ix_pokemon_is_default");

                entity.HasIndex(e => e.Order, "ix_pokemon_order");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseExperience).HasColumnName("base_experience");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_default");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.SpeciesId);
            });

            modelBuilder.Entity<PokemonAbility>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.Slot });

                entity.ToTable("pokemon_abilities");

                entity.HasIndex(e => e.IsHidden, "ix_pokemon_abilities_is_hidden");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.IsHidden)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_hidden");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.PokemonAbilities)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonAbilities)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonColor>(entity =>
            {
                entity.ToTable("pokemon_colors");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<PokemonColorName>(entity =>
            {
                entity.HasKey(e => new { e.PokemonColorId, e.LocalLanguageId });

                entity.ToTable("pokemon_color_names");

                entity.HasIndex(e => e.Name, "ix_pokemon_color_names_name");

                entity.Property(e => e.PokemonColorId).HasColumnName("pokemon_color_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonColorNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonColor)
                    .WithMany(p => p.PokemonColorNames)
                    .HasForeignKey(d => d.PokemonColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonDexNumber>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.PokedexId });

                entity.ToTable("pokemon_dex_numbers");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

                entity.Property(e => e.PokedexNumber).HasColumnName("pokedex_number");

                entity.HasOne(d => d.Pokedex)
                    .WithMany(p => p.PokemonDexNumbers)
                    .HasForeignKey(d => d.PokedexId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.PokemonDexNumbers)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonEggGroup>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.EggGroupId });

                entity.ToTable("pokemon_egg_groups");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");

                entity.HasOne(d => d.EggGroup)
                    .WithMany(p => p.PokemonEggGroups)
                    .HasForeignKey(d => d.EggGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.PokemonEggGroups)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonEvolution>(entity =>
            {
                entity.ToTable("pokemon_evolution");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");

                entity.Property(e => e.EvolvedSpeciesId).HasColumnName("evolved_species_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.HeldItemId).HasColumnName("held_item_id");

                entity.Property(e => e.KnownMoveId).HasColumnName("known_move_id");

                entity.Property(e => e.KnownMoveTypeId).HasColumnName("known_move_type_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MinimumAffection).HasColumnName("minimum_affection");

                entity.Property(e => e.MinimumBeauty).HasColumnName("minimum_beauty");

                entity.Property(e => e.MinimumHappiness).HasColumnName("minimum_happiness");

                entity.Property(e => e.MinimumLevel).HasColumnName("minimum_level");

                entity.Property(e => e.NeedsOverworldRain)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("needs_overworld_rain");

                entity.Property(e => e.PartySpeciesId).HasColumnName("party_species_id");

                entity.Property(e => e.PartyTypeId).HasColumnName("party_type_id");

                entity.Property(e => e.RelativePhysicalStats).HasColumnName("relative_physical_stats");

                entity.Property(e => e.TimeOfDay)
                    .HasColumnType("VARCHAR(5)")
                    .HasColumnName("time_of_day");

                entity.Property(e => e.TradeSpeciesId).HasColumnName("trade_species_id");

                entity.Property(e => e.TriggerItemId).HasColumnName("trigger_item_id");

                entity.Property(e => e.TurnUpsideDown)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("turn_upside_down");

                entity.HasOne(d => d.EvolutionTrigger)
                    .WithMany(p => p.PokemonEvolutions)
                    .HasForeignKey(d => d.EvolutionTriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.EvolvedSpecies)
                    .WithMany(p => p.PokemonEvolutionEvolvedSpecies)
                    .HasForeignKey(d => d.EvolvedSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.PokemonEvolutions)
                    .HasForeignKey(d => d.GenderId);

                entity.HasOne(d => d.HeldItem)
                    .WithMany(p => p.PokemonEvolutionHeldItems)
                    .HasForeignKey(d => d.HeldItemId);

                entity.HasOne(d => d.KnownMove)
                    .WithMany(p => p.PokemonEvolutions)
                    .HasForeignKey(d => d.KnownMoveId);

                entity.HasOne(d => d.KnownMoveType)
                    .WithMany(p => p.PokemonEvolutionKnownMoveTypes)
                    .HasForeignKey(d => d.KnownMoveTypeId);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PokemonEvolutions)
                    .HasForeignKey(d => d.LocationId);

                entity.HasOne(d => d.PartySpecies)
                    .WithMany(p => p.PokemonEvolutionPartySpecies)
                    .HasForeignKey(d => d.PartySpeciesId);

                entity.HasOne(d => d.PartyType)
                    .WithMany(p => p.PokemonEvolutionPartyTypes)
                    .HasForeignKey(d => d.PartyTypeId);

                entity.HasOne(d => d.TradeSpecies)
                    .WithMany(p => p.PokemonEvolutionTradeSpecies)
                    .HasForeignKey(d => d.TradeSpeciesId);

                entity.HasOne(d => d.TriggerItem)
                    .WithMany(p => p.PokemonEvolutionTriggerItems)
                    .HasForeignKey(d => d.TriggerItemId);
            });

            modelBuilder.Entity<PokemonForm>(entity =>
            {
                entity.ToTable("pokemon_forms");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FormIdentifier)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("form_identifier");

                entity.Property(e => e.FormOrder).HasColumnName("form_order");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IntroducedInVersionGroupId).HasColumnName("introduced_in_version_group_id");

                entity.Property(e => e.IsBattleOnly)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_battle_only");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_default");

                entity.Property(e => e.IsMega)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_mega");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.HasOne(d => d.IntroducedInVersionGroup)
                    .WithMany(p => p.PokemonForms)
                    .HasForeignKey(d => d.IntroducedInVersionGroupId);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonForms)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonFormGeneration>(entity =>
            {
                entity.HasKey(e => new { e.PokemonFormId, e.GenerationId });

                entity.ToTable("pokemon_form_generations");

                entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.PokemonFormGenerations)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonForm)
                    .WithMany(p => p.PokemonFormGenerations)
                    .HasForeignKey(d => d.PokemonFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonFormName>(entity =>
            {
                entity.HasKey(e => new { e.PokemonFormId, e.LocalLanguageId });

                entity.ToTable("pokemon_form_names");

                entity.HasIndex(e => e.FormName, "ix_pokemon_form_names_form_name");

                entity.HasIndex(e => e.PokemonName, "ix_pokemon_form_names_pokemon_name");

                entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FormName)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("form_name");

                entity.Property(e => e.PokemonName)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("pokemon_name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonFormNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonForm)
                    .WithMany(p => p.PokemonFormNames)
                    .HasForeignKey(d => d.PokemonFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonFormPokeathlonStat>(entity =>
            {
                entity.HasKey(e => new { e.PokemonFormId, e.PokeathlonStatId });

                entity.ToTable("pokemon_form_pokeathlon_stats");

                entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

                entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.Property(e => e.MaximumStat).HasColumnName("maximum_stat");

                entity.Property(e => e.MinimumStat).HasColumnName("minimum_stat");

                entity.HasOne(d => d.PokeathlonStat)
                    .WithMany(p => p.PokemonFormPokeathlonStats)
                    .HasForeignKey(d => d.PokeathlonStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonForm)
                    .WithMany(p => p.PokemonFormPokeathlonStats)
                    .HasForeignKey(d => d.PokemonFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonGameIndex>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.VersionId });

                entity.ToTable("pokemon_game_indices");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonGameIndices)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PokemonGameIndices)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonHabitat>(entity =>
            {
                entity.ToTable("pokemon_habitats");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<PokemonHabitatName>(entity =>
            {
                entity.HasKey(e => new { e.PokemonHabitatId, e.LocalLanguageId });

                entity.ToTable("pokemon_habitat_names");

                entity.HasIndex(e => e.Name, "ix_pokemon_habitat_names_name");

                entity.Property(e => e.PokemonHabitatId).HasColumnName("pokemon_habitat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonHabitatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonHabitat)
                    .WithMany(p => p.PokemonHabitatNames)
                    .HasForeignKey(d => d.PokemonHabitatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonItem>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.VersionId, e.ItemId });

                entity.ToTable("pokemon_items");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PokemonItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonItems)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PokemonItems)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonMove>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.VersionGroupId, e.MoveId, e.PokemonMoveMethodId, e.Level });

                entity.ToTable("pokemon_moves");

                entity.HasIndex(e => e.Level, "ix_pokemon_moves_level");

                entity.HasIndex(e => e.MoveId, "ix_pokemon_moves_move_id");

                entity.HasIndex(e => e.PokemonId, "ix_pokemon_moves_pokemon_id");

                entity.HasIndex(e => e.PokemonMoveMethodId, "ix_pokemon_moves_pokemon_move_method_id");

                entity.HasIndex(e => e.VersionGroupId, "ix_pokemon_moves_version_group_id");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.PokemonMoveMethodId).HasColumnName("pokemon_move_method_id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonMoveMethod)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.PokemonMoveMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonMoveMethod>(entity =>
            {
                entity.ToTable("pokemon_move_methods");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<PokemonMoveMethodProse>(entity =>
            {
                entity.HasKey(e => new { e.PokemonMoveMethodId, e.LocalLanguageId });

                entity.ToTable("pokemon_move_method_prose");

                entity.HasIndex(e => e.Name, "ix_pokemon_move_method_prose_name");

                entity.Property(e => e.PokemonMoveMethodId).HasColumnName("pokemon_move_method_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonMoveMethodProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonMoveMethod)
                    .WithMany(p => p.PokemonMoveMethodProses)
                    .HasForeignKey(d => d.PokemonMoveMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonShape>(entity =>
            {
                entity.ToTable("pokemon_shapes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<PokemonShapeProse>(entity =>
            {
                entity.HasKey(e => new { e.PokemonShapeId, e.LocalLanguageId });

                entity.ToTable("pokemon_shape_prose");

                entity.HasIndex(e => e.Name, "ix_pokemon_shape_prose_name");

                entity.Property(e => e.PokemonShapeId).HasColumnName("pokemon_shape_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.AwesomeName)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("awesome_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonShapeProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonShape)
                    .WithMany(p => p.PokemonShapeProses)
                    .HasForeignKey(d => d.PokemonShapeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesFlavorSummary>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.LocalLanguageId });

                entity.ToTable("pokemon_species_flavor_summaries");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorSummary).HasColumnName("flavor_summary");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonSpeciesFlavorSummaries)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.PokemonSpeciesFlavorSummaries)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.VersionId, e.LanguageId });

                entity.ToTable("pokemon_species_flavor_text");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.PokemonSpeciesFlavorTexts)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.PokemonSpeciesFlavorTexts)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PokemonSpeciesFlavorTexts)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesName>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.LocalLanguageId });

                entity.ToTable("pokemon_species_names");

                entity.HasIndex(e => e.Name, "ix_pokemon_species_names_name");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Genus).HasColumnName("genus");

                entity.Property(e => e.Name)
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonSpeciesNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.PokemonSpeciesNames)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesProse>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.LocalLanguageId });

                entity.ToTable("pokemon_species_prose");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FormDescription).HasColumnName("form_description");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonSpeciesProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.PokemonSpeciesProses)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpecy>(entity =>
            {
                entity.ToTable("pokemon_species");

                entity.HasIndex(e => e.ConquestOrder, "ix_pokemon_species_conquest_order");

                entity.HasIndex(e => e.Order, "ix_pokemon_species_order");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseHappiness).HasColumnName("base_happiness");

                entity.Property(e => e.CaptureRate).HasColumnName("capture_rate");

                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.ConquestOrder).HasColumnName("conquest_order");

                entity.Property(e => e.EvolutionChainId).HasColumnName("evolution_chain_id");

                entity.Property(e => e.EvolvesFromSpeciesId).HasColumnName("evolves_from_species_id");

                entity.Property(e => e.FormsSwitchable)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("forms_switchable");

                entity.Property(e => e.GenderRate).HasColumnName("gender_rate");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");

                entity.Property(e => e.HabitatId).HasColumnName("habitat_id");

                entity.Property(e => e.HasGenderDifferences)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("has_gender_differences");

                entity.Property(e => e.HatchCounter).HasColumnName("hatch_counter");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IsBaby)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_baby");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.ShapeId).HasColumnName("shape_id");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.EvolutionChain)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.EvolutionChainId);

                entity.HasOne(d => d.EvolvesFromSpecies)
                    .WithMany(p => p.InverseEvolvesFromSpecies)
                    .HasForeignKey(d => d.EvolvesFromSpeciesId);

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.GenerationId);

                entity.HasOne(d => d.GrowthRate)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.GrowthRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Habitat)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.HabitatId);

                entity.HasOne(d => d.Shape)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.ShapeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonStat>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.StatId });

                entity.ToTable("pokemon_stats");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.Property(e => e.Effort).HasColumnName("effort");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonStats)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.PokemonStats)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonType>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.Slot });

                entity.ToTable("pokemon_types");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonTypes)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PokemonTypes)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("regions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<RegionName>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.LocalLanguageId });

                entity.ToTable("region_names");

                entity.HasIndex(e => e.Name, "ix_region_names_name");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.RegionNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionNames)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Stat>(entity =>
            {
                entity.ToTable("stats");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DamageClassId).HasColumnName("damage_class_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.IsBattleOnly)
                    .IsRequired()
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("is_battle_only");

                entity.HasOne(d => d.DamageClass)
                    .WithMany(p => p.Stats)
                    .HasForeignKey(d => d.DamageClassId);
            });

            modelBuilder.Entity<StatName>(entity =>
            {
                entity.HasKey(e => new { e.StatId, e.LocalLanguageId });

                entity.ToTable("stat_names");

                entity.HasIndex(e => e.Name, "ix_stat_names_name");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.StatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.StatNames)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SuperContestCombo>(entity =>
            {
                entity.HasKey(e => new { e.FirstMoveId, e.SecondMoveId });

                entity.ToTable("super_contest_combos");

                entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");

                entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

                entity.HasOne(d => d.FirstMove)
                    .WithMany(p => p.SuperContestComboFirstMoves)
                    .HasForeignKey(d => d.FirstMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SecondMove)
                    .WithMany(p => p.SuperContestComboSecondMoves)
                    .HasForeignKey(d => d.SecondMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SuperContestEffect>(entity =>
            {
                entity.ToTable("super_contest_effects");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Appeal)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("appeal");
            });

            modelBuilder.Entity<SuperContestEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.SuperContestEffectId, e.LocalLanguageId });

                entity.ToTable("super_contest_effect_prose");

                entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.SuperContestEffectProses)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SuperContestEffect)
                    .WithMany(p => p.SuperContestEffectProses)
                    .HasForeignKey(d => d.SuperContestEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("types");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DamageClassId).HasColumnName("damage_class_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.HasOne(d => d.DamageClass)
                    .WithMany(p => p.Types)
                    .HasForeignKey(d => d.DamageClassId);

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.Types)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TypeEfficacy>(entity =>
            {
                entity.HasKey(e => new { e.DamageTypeId, e.TargetTypeId });

                entity.ToTable("type_efficacy");

                entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");

                entity.Property(e => e.TargetTypeId).HasColumnName("target_type_id");

                entity.Property(e => e.DamageFactor).HasColumnName("damage_factor");

                entity.HasOne(d => d.DamageType)
                    .WithMany(p => p.TypeEfficacyDamageTypes)
                    .HasForeignKey(d => d.DamageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TargetType)
                    .WithMany(p => p.TypeEfficacyTargetTypes)
                    .HasForeignKey(d => d.TargetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TypeGameIndex>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.GenerationId });

                entity.ToTable("type_game_indices");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.TypeGameIndices)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TypeGameIndices)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TypeName>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.LocalLanguageId });

                entity.ToTable("type_names");

                entity.HasIndex(e => e.Name, "ix_type_names_name");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.TypeNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TypeNames)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.ToTable("versions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.Versions)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionGroup>(entity =>
            {
                entity.ToTable("version_groups");

                entity.HasIndex(e => e.Identifier, "IX_version_groups_identifier")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("identifier");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.VersionGroups)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionGroupPokemonMoveMethod>(entity =>
            {
                entity.HasKey(e => new { e.VersionGroupId, e.PokemonMoveMethodId });

                entity.ToTable("version_group_pokemon_move_methods");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.PokemonMoveMethodId).HasColumnName("pokemon_move_method_id");

                entity.HasOne(d => d.PokemonMoveMethod)
                    .WithMany(p => p.VersionGroupPokemonMoveMethods)
                    .HasForeignKey(d => d.PokemonMoveMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.VersionGroupPokemonMoveMethods)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionGroupRegion>(entity =>
            {
                entity.HasKey(e => new { e.VersionGroupId, e.RegionId });

                entity.ToTable("version_group_regions");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.VersionGroupRegions)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.VersionGroupRegions)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionName>(entity =>
            {
                entity.HasKey(e => new { e.VersionId, e.LocalLanguageId });

                entity.ToTable("version_names");

                entity.HasIndex(e => e.Name, "ix_version_names_name");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR(79)")
                    .HasColumnName("name");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.VersionNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.VersionNames)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
