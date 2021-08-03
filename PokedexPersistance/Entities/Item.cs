using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Item
    {
        public Item()
        {
            Berries = new HashSet<Berry>();
            ConquestPokemonEvolutions = new HashSet<ConquestPokemonEvolution>();
            EvolutionChains = new HashSet<EvolutionChain>();
            ItemFlagMaps = new HashSet<ItemFlagMap>();
            ItemFlavorSummaries = new HashSet<ItemFlavorSummary>();
            ItemFlavorTexts = new HashSet<ItemFlavorText>();
            ItemGameIndices = new HashSet<ItemGameIndex>();
            ItemNames = new HashSet<ItemName>();
            ItemProses = new HashSet<ItemProse>();
            Machines = new HashSet<Machine>();
            PokemonEvolutionHeldItems = new HashSet<PokemonEvolution>();
            PokemonEvolutionTriggerItems = new HashSet<PokemonEvolution>();
            PokemonItems = new HashSet<PokemonItem>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long CategoryId { get; set; }
        public long Cost { get; set; }
        public long? FlingPower { get; set; }
        public long? FlingEffectId { get; set; }

        public virtual ItemCategory Category { get; set; }
        public virtual ItemFlingEffect FlingEffect { get; set; }
        public virtual ICollection<Berry> Berries { get; set; }
        public virtual ICollection<ConquestPokemonEvolution> ConquestPokemonEvolutions { get; set; }
        public virtual ICollection<EvolutionChain> EvolutionChains { get; set; }
        public virtual ICollection<ItemFlagMap> ItemFlagMaps { get; set; }
        public virtual ICollection<ItemFlavorSummary> ItemFlavorSummaries { get; set; }
        public virtual ICollection<ItemFlavorText> ItemFlavorTexts { get; set; }
        public virtual ICollection<ItemGameIndex> ItemGameIndices { get; set; }
        public virtual ICollection<ItemName> ItemNames { get; set; }
        public virtual ICollection<ItemProse> ItemProses { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionHeldItems { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionTriggerItems { get; set; }
        public virtual ICollection<PokemonItem> PokemonItems { get; set; }
    }
}
