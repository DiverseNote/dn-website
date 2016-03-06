using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DiverseNote.Objects;
using DiverseNote.Objects.SearchCriteria;

namespace DiverseNote.Business.Search
{
    public class CriteriaExpresssionProvider
    {
        public Expression<Func<Candidate, bool>> GetExpression(CandidateCriteria candidateCriteria)
        {
            throw new NotImplementedException();
        }

        private Expression SkillsExpressionProvider(IEnumerable<Skill> skills)
        {
            throw new NotImplementedException();
        }
    }
}
