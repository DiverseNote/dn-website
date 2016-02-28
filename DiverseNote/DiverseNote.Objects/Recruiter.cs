using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiverseNote.Objects.SearchCriteria;

namespace DiverseNote.Objects
{
    public class Recruiter
    {
        public int RecruiterId { get; set; }
        public int OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
