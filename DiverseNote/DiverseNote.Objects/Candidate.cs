using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseNote.Objects
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<College> Educations { get; set; }


    }
}
