using System;
using System.Collections.Generic;
using DiverseNote.Objects;

namespace DiverseNote.Data.Extensions
{
    public static class EntityExtensions
    {
        private static readonly Dictionary<string, string> CollectionNames = new Dictionary<string, string>
        {
            {typeof(Candidate).Name, "candidates"},
            {typeof(College).Name, "colleges"},
            {typeof(Experience).Name, "experience"},
            {typeof(Job).Name, "jobs"},
            {typeof(License).Name, "licenses"},
            {typeof(Organization).Name, "organizations"},
            {typeof(Recruiter).Name, "recruiters"},
            {typeof(Skill).Name, "skills"}
        }; 
         
        public static string GetCollectionName(this Type entityName)
        {
            return CollectionNames[entityName.Name];
        }
    }
}
