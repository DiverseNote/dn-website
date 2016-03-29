using System.Collections.Generic;
using System.Linq;
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
                Experiences = candidate.Experiences,
                ExperienceLevel = candidate.ExperienceLevel,
                Tags = GetTags(candidate)
            };
        }

        private static IEnumerable<string> GetTags(Candidate candidate)
        {
            var tags = new List<string>();
            if(candidate.ExperienceLevel != null)
                tags.Add(candidate.ExperienceLevel.ToString().ToLower());

            if(candidate.EthnicityTypes != null && candidate.EthnicityTypes.Any())
                tags.AddRange(candidate.EthnicityTypes.Select(x => x.ToString().ToLower()));

            tags.Add(candidate.Gender.ToString().ToLower());

            if(candidate.IsDisabled)
                tags.Add("disabled");

            if(candidate.IsLgbtq)
                tags.Add("lgbtq");

            if(candidate.IsVeteran)
                tags.Add("veteran");

            return tags;
        }
    }
}
