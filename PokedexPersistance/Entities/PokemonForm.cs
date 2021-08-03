using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonForm
    {
        public PokemonForm()
        {
            PokemonFormGenerations = new HashSet<PokemonFormGeneration>();
            PokemonFormNames = new HashSet<PokemonFormName>();
            PokemonFormPokeathlonStats = new HashSet<PokemonFormPokeathlonStat>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public string FormIdentifier { get; set; }
        public long PokemonId { get; set; }
        public long? IntroducedInVersionGroupId { get; set; }
        public byte[] IsDefault { get; set; }
        public byte[] IsBattleOnly { get; set; }
        public byte[] IsMega { get; set; }
        public long FormOrder { get; set; }
        public long Order { get; set; }

        public virtual VersionGroup IntroducedInVersionGroup { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual ICollection<PokemonFormGeneration> PokemonFormGenerations { get; set; }
        public virtual ICollection<PokemonFormName> PokemonFormNames { get; set; }
        public virtual ICollection<PokemonFormPokeathlonStat> PokemonFormPokeathlonStats { get; set; }
    }
}
