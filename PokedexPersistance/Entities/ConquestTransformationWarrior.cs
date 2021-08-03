using System;
using System.Collections.Generic;

#nullable disable

namespace PokedexPersistance.Entities
{
    public partial class ConquestTransformationWarrior
    {
        public long TransformationId { get; set; }
        public long PresentWarriorId { get; set; }

        public virtual ConquestWarrior PresentWarrior { get; set; }
        public virtual ConquestWarriorTransformation Transformation { get; set; }
    }
}
