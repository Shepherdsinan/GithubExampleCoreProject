using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using GithubExampleCoreProject.CQRS.Queries.GuideQueries;
using GithubExampleCoreProject.CQRS.Results.GuideResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GithubExampleCoreProject.CQRS.Handlers.GuideHandler
{
    public class GetAllGuideQueryHandler :IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideId = x.GuideID,
                Name = x.Name,
                Description = x.Description,
                Image = x.Image
            }).AsNoTracking().ToListAsync();
        }
    }
}