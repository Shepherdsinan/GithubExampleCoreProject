using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubExampleCoreProject.CQRS.Results.GuideResult
{
    public class GetGuideByIDQueryResult
    {
        public int GuideId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}