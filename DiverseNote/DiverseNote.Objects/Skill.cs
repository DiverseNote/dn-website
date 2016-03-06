using System;

namespace DiverseNote.Objects
{
    public class Skill : IEntity
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsProprietary { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}