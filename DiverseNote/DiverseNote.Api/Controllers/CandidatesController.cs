using System.Collections.Generic;
using System.Web.Http;
using DiverseNote.Objects;

namespace DiverseNote.Api.Controllers
{
    public class CandidatesController : ApiController
    {
        // GET: api/Candidates
        public IHttpActionResult Get()
        {
            var candidates = new List<Candidate>();
            return Ok(candidates);
        }

        // GET: api/Candidates/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Candidates
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Candidates/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Candidates/5
        public void Delete(int id)
        {
        }
    }
}
