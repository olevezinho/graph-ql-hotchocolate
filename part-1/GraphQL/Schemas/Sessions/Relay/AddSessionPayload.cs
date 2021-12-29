using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data.Models;

namespace ConferencePlanner.GraphQL.Schemas.Sessions.Relay
{
    public class AddSessionPayload : SessionPayloadBase
    {
        public AddSessionPayload(UserError error)
            : base(new[] { error })
        {
        }

        public AddSessionPayload(Session session) : base(session)
        {
        }

        public AddSessionPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}