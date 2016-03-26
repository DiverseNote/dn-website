using DiverseNote.Objects;
using DiverseNote.Objects.Index;

namespace DiverseNote.IndexService.ConversionExtensions
{
    public static class ConvertCandidate
    {
        public static IndexCandidate GetIndexCandidate(this Candidate candidate)
        {
            return new IndexCandidate
            {
                Id = candidate.Id,
                FirstName = candidate.FirstName,
                LastName = candidate.LastName,
                Description = candidate.Description,
                Skills = candidate.Skills,
                Schools = candidate.Schools,
                Experiences = candidate.Experiences
            };
        }
    }
}
