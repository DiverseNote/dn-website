using System.Collections.Generic;
using System.Threading.Tasks;
using DiverseNote.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiverseNote.Data.Test
{
    [TestClass]
    public class CandidateContext_Test
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task GetRecruitersTest_RecruitersExist()
        {
            var recruiterContext = new MongoRepository<Candidate>();

            var candidateId = await recruiterContext.InsertOneAsync(new Candidate
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                IsActive = true,
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Name = "Java",
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
