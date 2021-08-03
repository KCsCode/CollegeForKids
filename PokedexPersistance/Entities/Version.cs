using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Version
    {
        public Version()
        {
            Encounters = new HashSet<Encounter>();
            LocationAreaEncounterRates = new HashSet<LocationAreaEncounterRate>();
            PokemonGameIndices = new HashSet<PokemonGameIndex>();
            PokemonItems = new HashSet<PokemonItem>();
            PokemonSpeciesFlavorTexts = new HashSet<PokemonSpeciesFlavorText>();
            VersionNames = new HashSet<VersionName>();
        }

        public long Id { get; set; }
        public long VersionGroupId { get; set; }
        public string Identifier { get; set; }

        public virtual VersionGroup VersionGroup { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
        public virtual ICollection<LocationAreaEncounterRate> LocationAreaEncounterRates { get; set; }
        public virtual ICollection<PokemonGameIndex> PokemonGameIndices { get; set; }
        public virtual ICollection<PokemonItem> PokemonItems { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorText> PokemonSpeciesFlavorTexts { get; set; }
        public virtual ICollection<VersionName> VersionNames { get; set; }
    }
}
