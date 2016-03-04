using System;
using System.Linq;
using System.Threading.Tasks;
using DiverseNote.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using MongoDB.Driver;
using DiverseNote.Data;

namespace DiverseNote.Data.Test
{
    [TestClass]
    public class RecruiterContext_Test
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task GetRecruitersTest_RecruitersExist()
        {
            var recruiterContext = new DataContext<Recruiter>();
            
             var recruiterId = await recruiterContext.InsertOne(new Recruiter {FirstName = "TestFirstName", LastName = "TestLastName", OrganizationId = 1});
            
            var recruiters = recruiterContext.FindMany(x => x.Id == recruiterId);

            Assert.IsNotNull(recruiterId);
            Assert.IsTrue(recruiters.Any());
        }
    }
}
