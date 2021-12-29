using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.Data.Models;
using ConferencePlanner.GraphQL.Extensions;
using ConferencePlanner.GraphQL.Schemas.Speakers.Dto;
using ConferencePlanner.GraphQL.Schemas.Speakers.Relay;
using HotChocolate;
using HotChocolate.Types;

namespace ConferencePlanner.GraphQL.Schemas.Speakers.Mutations
{
    [ExtendObjectType("Mutation")]
    public class SpeakerMutation
    {
        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [ScopedService] ApplicationDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }
    }
}