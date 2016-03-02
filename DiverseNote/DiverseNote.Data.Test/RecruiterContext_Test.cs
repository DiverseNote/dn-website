using System;
using System.Linq;
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
        public void AddRecruiter_Success()
        {
           
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void GetRecruitersTest_RecruitersExist()
        {
            var recruiterContext = new RecruiterContext();
            recruiterContext.DeleteAll();
            recruiterContext.InsertRecruiter(new Recruiter {FirstName = "Allen", LastName = "Lee", OrganizationId = 1});

            var recruiters = recruiterContext.GetRecruiters();

            Assert.IsTrue(recruiters.Any());}
    }
}
