using System;

namespace DiverseNote.Objects
{
    public interface IEntity
    {
        string Id { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
