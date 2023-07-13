using DataAccessLayer.Concrete;
using GithubExampleCoreProject.CQRS.Queries.DestinationQueries;
using GithubExampleCoreProject.CQRS.Results.DestinationResults;

namespace GithubExampleCoreProject.CQRS.Handlers.DestinationHandlers;

public class GetDestinationByIDQueryHandler
{
    private readonly Context _context;

    public GetDestinationByIDQueryHandler(Context context)
    {
        _context = context;
    }

    public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
    {
        var values = _context.Destinations.Find(query.Id);
        return new GetDestinationByIDQueryResult
        {
            DestinationId = values.DestinationID,
            City = values.City,
            Daynight = values.DayNight
        };
    }
}