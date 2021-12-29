namespace ConferencePlanner.GraphQL.Schemas.Speakers.Dto
{
    public record AddSpeakerInput(
        string Name,
        string? Bio,
        string? WebSite);
}