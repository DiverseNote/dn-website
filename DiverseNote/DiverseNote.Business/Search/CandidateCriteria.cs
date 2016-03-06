using System.Collections.Generic;

namespace DiverseNote.Objects.SearchCriteria
{
    public class CandidateCriteria
    {
        public IEnumerable<string> Keywords { get; set; }
        public bool IsVeteran { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsLgbq { get; set; }
        public char Gender { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }        
        public IEnumerable<ExperienceLevel> ExperienceLevel { get; set; }
    }
}