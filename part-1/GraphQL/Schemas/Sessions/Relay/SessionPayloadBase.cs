using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data.Models;

namespace ConferencePlanner.GraphQL.Schemas.Sessions.Relay
{
    public class SessionPayloadBase : Payload
    {
        protected SessionPayloadBase(Session session)
        {
            Session = session;
        }

        protected SessionPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Session? Session { get; }
    }
}