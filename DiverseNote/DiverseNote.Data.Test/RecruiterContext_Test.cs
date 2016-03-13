using System.Threading.Tasks;
using DiverseNote.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiverseNote.Data.EntityRepositories;

namespace DiverseNote.Data.Test
{
    [TestClass]
    public class RecruiterContext_Test
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task GetRecruitersTest_RecruitersExist()
        {
            var recruiterContext = new RecruiterRepository();
            var recruiterId = await recruiterContext.InsertOneAsync(new Recruiter {FirstName = "TestFirstName", LastName = "TestLastName", OrganizationId = 1});
            var recruiter = await recruiterContext.FindOneAsync(x => x.Id == recruiterId);

            Assert.IsNotNull(recruiterId);
            Assert.IsNotNull(recruiter);
        }
    }
}
