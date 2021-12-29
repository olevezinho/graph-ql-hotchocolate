using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.Data.Models;
using ConferencePlanner.GraphQL.Extensions;
using ConferencePlanner.GraphQL.Schemas.Tracks.Dto;
using ConferencePlanner.GraphQL.Schemas.Tracks.Relay;
using ConferencePlanner.GraphQL.Tracks;
using HotChocolate;
using HotChocolate.Types;

namespace ConferencePlanner.GraphQL.Schemas.Tracks.Mutations
{
    [ExtendObjectType("Mutation")]
    public class TrackMutations
    {
        [UseApplicationDbContext]
        public async Task<AddTrackPayload> AddTrackAsync(
            AddTrackInput input,
            [ScopedService] ApplicationDbContext context,
            CancellationToken cancellationToken)
        {
            var track = new Track { Name = input.Name };
            context.Tracks.Add(track);

            await context.SaveChangesAsync(cancellationToken);

            return new AddTrackPayload(track);
        }

        [UseApplicationDbContext]
        public async Task<RenameTrackPayload> RenameTrackAsync(
            RenameTrackInput input,
            [ScopedService] ApplicationDbContext context,
            CancellationToken cancellationToken)
        {
            Track track = await context.Tracks.FindAsync(input.Id) ?? throw new Exception("Id not found");
            track.Name = input.Name;
        
            await context.SaveChangesAsync(cancellationToken);
        
            return new RenameTrackPayload(track);
        }
    }
}