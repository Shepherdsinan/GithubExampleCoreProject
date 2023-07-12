namespace GithubExampleCoreProject.CQRS.Results.DestinationResults;

public class GetAllDestinationQueryResult
{
    public int Id { get; set; }
    public string? City { get; set; }
    public string? Daynight { get; set; }
    public double Price { get; set; }
    public float Capacity { get; set; }
}