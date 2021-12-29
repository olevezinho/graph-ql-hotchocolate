namespace ConferencePlanner.GraphQL.Schemas.Attendees.Dto
{
    public record RegisterAttendeeInput(
        string FirstName,
        string LastName,
        string UserName,
        string EmailAddress);
}