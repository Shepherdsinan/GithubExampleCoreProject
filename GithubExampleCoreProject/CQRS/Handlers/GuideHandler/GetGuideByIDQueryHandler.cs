using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using GithubExampleCoreProject.CQRS.Queries.GuideQueries;
using GithubExampleCoreProject.CQRS.Results.GuideResult;
using MediatR;

namespace GithubExampleCoreProject.CQRS.Handlers.GuideHandler
{
    public class GetGuideByIDQueryHandler 
    {

        /*private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = _context.Guides.FindAsync(request.Id);
            return new GetAllGuideQueryResult
            {
                GuideId = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }*/
    }
}