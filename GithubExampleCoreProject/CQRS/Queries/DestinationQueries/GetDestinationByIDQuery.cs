using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubExampleCoreProject.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIDQuery
    {
        public GetDestinationByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
