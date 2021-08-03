using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestPokemonEvolution
    {
        public long EvolvedSpeciesId { get; set; }
        public long? RequiredStatId { get; set; }
        public long? MinimumStat { get; set; }
        public long? MinimumLink { get; set; }
        public long? KingdomId { get; set; }
        public long? WarriorGenderId { get; set; }
        public long? ItemId { get; set; }
        public byte[] RecruitingKoRequired { get; set; }

        public virtual PokemonSpecy EvolvedSpecies { get; set; }
        public virtual Item Item { get; set; }
        public virtual ConquestKingdom Kingdom { get; set; }
        public virtual ConquestStat RequiredStat { get; set; }
        public virtual Gender WarriorGender { get; set; }
    }
}
