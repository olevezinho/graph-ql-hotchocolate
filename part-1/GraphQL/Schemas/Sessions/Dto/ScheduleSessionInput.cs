using ConferencePlanner.GraphQL.Data.Models;
using HotChocolate.Types.Relay;

namespace ConferencePlanner.GraphQL.Schemas.Sessions.Dto
{
    public record ScheduleSessionInput(
        [ID(nameof(Session))]
        int SessionId,
        [ID(nameof(Track))]
        int TrackId,
        DateTimeOffset StartTime,
        DateTimeOffset EndTime);
}