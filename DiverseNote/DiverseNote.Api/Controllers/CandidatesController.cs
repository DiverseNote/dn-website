using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using DiverseNote.Business.Interfaces;
using DiverseNote.Objects;

namespace DiverseNote.Api.Controllers
{
    public class CandidatesController : ApiController
    {
        private readonly ICandidateProvider _candidateProvider;
        public CandidatesController(ICandidateProvider candidateProvider)
        {
            _candidateProvider = candidateProvider;
        }

        // GET: api/Candidates
        public IHttpActionResult Get()
        {
            var candidates = new List<Candidate>();
            return Ok(candidates);
        }

        // GET: api/Candidates/5
        public async Task<IHttpActionResult> Get(string id)
        {
            try
            {
                var candidate = await _candidateProvider.GetCandidateAsync(id, new UserAccount());
                return Ok(candidate);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // POST: api/Candidates
        public async Task<IHttpActionResult> Post([FromBody]Candidate candidate)
        {
            try
            {
                var id = await _candidateProvider.AddCandidateAsync(candidate, new UserAccount());
                return Ok(id);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // PUT: api/Candidates/5
        public async Task<IHttpActionResult> Put(string id, [FromBody]Candidate candidate)
        {
            try
            {
                await _candidateProvider.UpdateCandidateAsync(candidate, new UserAccount());
                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Candidates/5
        public async Task<IHttpActionResult> Delete(string id)
        {
            try
            {
                await _candidateProvider.DeleteCandidateAsync(id, new UserAccount());
                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
