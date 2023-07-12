using DataAccessLayer.Concrete;
using GithubExampleCoreProject.CQRS.Results.DestinationResults;
using Microsoft.EntityFrameworkCore;

namespace GithubExampleCoreProject.CQRS.Handlers.DestinationHandlers;

public class GetAllDestinationQueryHandler
{
    private readonly Context _context;

    public GetAllDestinationQueryHandler(Context context)
    {
        _context = context;
    }

    public List<GetAllDestinationQueryResult> Handle()
    {
        var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
        {
            Id = x.DestinationID,
            Capacity = x.Capacity,
            City = x.City,
            Price = x.Price
        }).AsNoTracking().ToList();
        return values;
    }
}