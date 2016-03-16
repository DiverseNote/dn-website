using System.Collections.Generic;
using System.Web.Http;
using DiverseNote.Objects;
using DiverseNote.Business;
using DiverseNote.Business.Providers;

namespace DiverseNote.Api.Controllers
{
    public class RecruitersController : ApiController
    {

        private readonly RecruiterProvider _recruiterProvider;

        public RecruitersController(RecruiterProvider recruiterProvider)
        {
            _recruiterProvider = recruiterProvider;
        }

        // GET: api/Recruiters
        public IHttpActionResult Get()
        {
            var recruiters = new List<Recruiter>();
            return Ok(recruiters);
        }

        // GET: api/Recruiters/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Recruiters
        public void Post([FromBody]Recruiter recruiter)
        {
            _recruiterProvider.AddRecruiter(recruiter);
        }

        // PUT: api/Candidates/5
        public void Put(int id, [FromBody]Recruiter value)
        {
        }

        // DELETE: api/Candidates/5
        public void Delete(int id)
        {
        }
    }
}
