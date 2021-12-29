using ConferencePlanner.GraphQL.Data.Models;
using HotChocolate.Types.Relay;

namespace ConferencePlanner.GraphQL.Schemas.Sessions.Dto
{
    public record AddSessionInput(
        string Title,
        string? Abstract,
        [ID(nameof(Speaker))]
        IReadOnlyList<int> SpeakerIds);
}