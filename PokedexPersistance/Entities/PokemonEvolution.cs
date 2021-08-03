using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class PokemonEvolution
    {
        public long Id { get; set; }
        public long EvolvedSpeciesId { get; set; }
        public long EvolutionTriggerId { get; set; }
        public long? TriggerItemId { get; set; }
        public long? MinimumLevel { get; set; }
        public long? GenderId { get; set; }
        public long? LocationId { get; set; }
        public long? HeldItemId { get; set; }
        public string TimeOfDay { get; set; }
        public long? KnownMoveId { get; set; }
        public long? KnownMoveTypeId { get; set; }
        public long? MinimumHappiness { get; set; }
        public long? MinimumBeauty { get; set; }
        public long? MinimumAffection { get; set; }
        public long? RelativePhysicalStats { get; set; }
        public long? PartySpeciesId { get; set; }
        public long? PartyTypeId { get; set; }
        public long? TradeSpeciesId { get; set; }
        public byte[] NeedsOverworldRain { get; set; }
        public byte[] TurnUpsideDown { get; set; }

        public virtual EvolutionTrigger EvolutionTrigger { get; set; }
        public virtual PokemonSpecy EvolvedSpecies { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Item HeldItem { get; set; }
        public virtual Move KnownMove { get; set; }
        public virtual Type KnownMoveType { get; set; }
        public virtual Location Location { get; set; }
        public virtual PokemonSpecy PartySpecies { get; set; }
        public virtual Type PartyType { get; set; }
        public virtual PokemonSpecy TradeSpecies { get; set; }
        public virtual Item TriggerItem { get; set; }
    }
}
