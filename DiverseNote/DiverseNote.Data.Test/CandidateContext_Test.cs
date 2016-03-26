using System.Collections.Generic;
using System.Threading.Tasks;
using DiverseNote.Data.EntityRepositories;
using DiverseNote.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiverseNote.Data.Test
{
    [TestClass]
    public class CandidateContext_Test
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task GetCandidatesTest_RecruitersExist()
        {
            var recruiterContext = new CandidateRepository();

            var candidateId = await recruiterContext.InsertOneAsync(new Candidate
            {
                FirstName = "Bruce",
                LastName = "Morgan",
                Description = "Experience with financial modeling, derivatives, and real estate. Coding experience mainly with Rails & Meteor (associated work with Javascript/HTML/CSS/etc",
                IsActive = true,
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Name = "HTML5",
                        IsProprietary = true
                    },
                    new Skill
                    {
                        Name = "CSS3",
                        IsProprietary = true
                    }
                }
            });
            var candidate = await recruiterContext.FindOneAsync(x => x.Id == candidateId);

            Assert.IsNotNull(candidateId);
            Assert.IsNotNull(candidate);
        }
    }
}
