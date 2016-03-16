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
                FirstName = "Toriano",
                LastName = "Moore",
                Description = "Senior Leader for 5 years",
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
