using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data.Models;
using ConferencePlanner.GraphQL.Schemas.Tracks.Relay;

namespace ConferencePlanner.GraphQL.Tracks
{
    public class RenameTrackPayload : TrackPayloadBase
    {
        public RenameTrackPayload(Track track) 
            : base(track)
        {
        }

        public RenameTrackPayload(IReadOnlyList<UserError> errors) 
            : base(errors)
        {
        }
    }
}