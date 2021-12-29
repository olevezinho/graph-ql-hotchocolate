using ConferencePlanner.GraphQL.Data.Models;
using HotChocolate.Types.Relay;

namespace ConferencePlanner.GraphQL.Schemas.Attendees.Dto
{
    public record CheckInAttendeeInput(
        [ID(nameof(Session))]
        int SessionId,
        [ID(nameof(Attendee))]
        int AttendeeId);
}