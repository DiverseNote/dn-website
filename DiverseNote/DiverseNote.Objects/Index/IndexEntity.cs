using System.Collections.Generic;

namespace DiverseNote.Objects.Index
{
    public interface IIndexEntity
    {
        string ObjectId { get; }
        IEnumerable<string> Tags { get; set; }
    }
}
