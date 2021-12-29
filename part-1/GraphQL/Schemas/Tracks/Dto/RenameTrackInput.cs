using ConferencePlanner.GraphQL.Data.Models;
using HotChocolate.Types.Relay;

namespace ConferencePlanner.GraphQL.Schemas.Tracks.Dto
{
    public record RenameTrackInput([ID(nameof(Track))] int Id, string Name);
}