using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class Stat
    {
        public Stat()
        {
            Characteristics = new HashSet<Characteristic>();
            MoveMetaStatChanges = new HashSet<MoveMetaStatChange>();
            NatureDecreasedStats = new HashSet<Nature>();
            NatureIncreasedStats = new HashSet<Nature>();
            PokemonStats = new HashSet<PokemonStat>();
            StatNames = new HashSet<StatName>();
        }

        public long Id { get; set; }
        public long? DamageClassId { get; set; }
        public string Identifier { get; set; }
        public byte[] IsBattleOnly { get; set; }
        public long? GameIndex { get; set; }

        public virtual MoveDamageClass DamageClass { get; set; }
        public virtual ICollection<Characteristic> Characteristics { get; set; }
        public virtual ICollection<MoveMetaStatChange> MoveMetaStatChanges { get; set; }
        public virtual ICollection<Nature> NatureDecreasedStats { get; set; }
        public virtual ICollection<Nature> NatureIncreasedStats { get; set; }
        public virtual ICollection<PokemonStat> PokemonStats { get; set; }
        public virtual ICollection<StatName> StatNames { get; set; }
    }
}
