using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data.Models;

namespace ConferencePlanner.GraphQL.Schemas.Speakers.Relay
{
    public class AddSpeakerPayload : SpeakerPayloadBase
    {
        public AddSpeakerPayload(Speaker speaker) 
            : base(speaker)
        {
        }

        protected AddSpeakerPayload(IReadOnlyList<UserError> errors) 
            : base(errors)
        {
        }
    }
}