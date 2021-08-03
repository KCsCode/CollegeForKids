using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonSpecy
    {
        public PokemonSpecy()
        {
            ConquestMaxLinks = new HashSet<ConquestMaxLink>();
            ConquestPokemonAbilities = new HashSet<ConquestPokemonAbility>();
            ConquestPokemonStats = new HashSet<ConquestPokemonStat>();
            ConquestTransformationPokemons = new HashSet<ConquestTransformationPokemon>();
            InverseEvolvesFromSpecies = new HashSet<PokemonSpecy>();
            PokemonDexNumbers = new HashSet<PokemonDexNumber>();
            PokemonEggGroups = new HashSet<PokemonEggGroup>();
            PokemonEvolutionEvolvedSpecies = new HashSet<PokemonEvolution>();
            PokemonEvolutionPartySpecies = new HashSet<PokemonEvolution>();
            PokemonEvolutionTradeSpecies = new HashSet<PokemonEvolution>();
            PokemonSpeciesFlavorSummaries = new HashSet<PokemonSpeciesFlavorSummary>();
            PokemonSpeciesFlavorTexts = new HashSet<PokemonSpeciesFlavorText>();
            PokemonSpeciesNames = new HashSet<PokemonSpeciesName>();
            PokemonSpeciesProses = new HashSet<PokemonSpeciesProse>();
            Pokemons = new HashSet<Pokemon>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long? GenerationId { get; set; }
        public long? EvolvesFromSpeciesId { get; set; }
        public long? EvolutionChainId { get; set; }
        public long ColorId { get; set; }
        public long ShapeId { get; set; }
        public long? HabitatId { get; set; }
        public long GenderRate { get; set; }
        public long CaptureRate { get; set; }
        public long BaseHappiness { get; set; }
        public byte[] IsBaby { get; set; }
        public long HatchCounter { get; set; }
        public byte[] HasGenderDifferences { get; set; }
        public long GrowthRateId { get; set; }
        public byte[] FormsSwitchable { get; set; }
        public long Order { get; set; }
        public long? ConquestOrder { get; set; }

        public virtual PokemonColor Color { get; set; }
        public virtual EvolutionChain EvolutionChain { get; set; }
        public virtual PokemonSpecy EvolvesFromSpecies { get; set; }
        public virtual Generation Generation { get; set; }
        public virtual GrowthRate GrowthRate { get; set; }
        public virtual PokemonHabitat Habitat { get; set; }
        public virtual PokemonShape Shape { get; set; }
        public virtual ConquestPokemonEvolution ConquestPokemonEvolution { get; set; }
        public virtual ConquestPokemonMove ConquestPokemonMove { get; set; }
        public virtual PalPark PalPark { get; set; }
        public virtual ICollection<ConquestMaxLink> ConquestMaxLinks { get; set; }
        public virtual ICollection<ConquestPokemonAbility> ConquestPokemonAbilities { get; set; }
        public virtual ICollection<ConquestPokemonStat> ConquestPokemonStats { get; set; }
        public virtual ICollection<ConquestTransformationPokemon> ConquestTransformationPokemons { get; set; }
        public virtual ICollection<PokemonSpecy> InverseEvolvesFromSpecies { get; set; }
        public virtual ICollection<PokemonDexNumber> PokemonDexNumbers { get; set; }
        public virtual ICollection<PokemonEggGroup> PokemonEggGroups { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionEvolvedSpecies { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionPartySpecies { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionTradeSpecies { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorSummary> PokemonSpeciesFlavorSummaries { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorText> PokemonSpeciesFlavorTexts { get; set; }
        public virtual ICollection<PokemonSpeciesName> PokemonSpeciesNames { get; set; }
        public virtual ICollection<PokemonSpeciesProse> PokemonSpeciesProses { get; set; }
        public virtual ICollection<Pokemon> Pokemons { get; set; }
    }
}
