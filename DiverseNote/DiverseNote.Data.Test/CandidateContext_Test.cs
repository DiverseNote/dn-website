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
                FirstName = "Quinn",
                LastName = "St Piere",
                Description = "In a team of three, built out a new web application from the ground up. Personally, I architected the front end as a single page application using Backbone, Require, Handlebars, LESS and Bootstrap, tooling NPM, Grunt and Bower, as well as built the beautifully restful api with which it communicated.Experience with financial modeling, derivatives, and real estate. Coding experience mainly with Rails & Meteor (associated work with Javascript/HTML/CSS/etc",
                IsActive = true,
                IsDisabled = true,
                IsLgbtq = true,
                IsVeteran = true,
                EthnicityTypes = new List<EthnicityTypes>
                {
                    EthnicityTypes.AfricanAmerican,
                    EthnicityTypes.NativeAmerican
                },
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Name = "ReactJs",
                        IsProprietary = true
                    },
                    new Skill
                    {
                        Name = "CSS3",
                        IsProprietary = true
                    }
                },
                ExperienceLevel = ExperienceLevel.Executive
            });

            var candidate = await recruiterContext.FindOneAsync(x => x.Id == candidateId);

            Assert.IsNotNull(candidateId);
            Assert.IsNotNull(candidate);
        }
    }
}
