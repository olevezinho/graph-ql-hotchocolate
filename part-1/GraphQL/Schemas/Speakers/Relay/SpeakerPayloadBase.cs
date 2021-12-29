using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data.Models;

namespace ConferencePlanner.GraphQL.Schemas.Speakers.Relay
{
    public class SpeakerPayloadBase : Payload
    {
        protected SpeakerPayloadBase(Speaker speaker)
        {
            Speaker = speaker;
        }

        protected SpeakerPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Speaker? Speaker { get; }
    }
}