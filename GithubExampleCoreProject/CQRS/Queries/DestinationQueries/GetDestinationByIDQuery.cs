namespace GithubExampleCoreProject.CQRS.Queries.DestinationQueries;

public class GetDestinationByIDQuery
{
    public GetDestinationByIDQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}