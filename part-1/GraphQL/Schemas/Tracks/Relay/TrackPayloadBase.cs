using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data.Models;

namespace ConferencePlanner.GraphQL.Schemas.Tracks.Relay
{
    public class TrackPayloadBase : Payload
    {
        public TrackPayloadBase(Track track)
        {
            Track = track;
        }

        public TrackPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Track? Track { get; }
    }
}