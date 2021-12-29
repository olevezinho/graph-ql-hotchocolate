using ConferencePlanner.GraphQL.Data.Models;
using ConferencePlanner.GraphQL.DataLoader;
using HotChocolate;
using HotChocolate.Types;

namespace ConferencePlanner.GraphQL.Schemas.Sessions.Subscriptions
{
    [ExtendObjectType(Name = "Subscription")]
    public class SessionSubscription
    {
        [Subscribe]
        [Topic]
        public Task<Session> OnSessionScheduledAsync(
            [EventMessage] int sessionId,
            SessionByIdDataLoader sessionById,
            CancellationToken cancellationToken) =>
            sessionById.LoadAsync(sessionId, cancellationToken);
    }
}