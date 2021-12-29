using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.DataLoader;
using ConferencePlanner.GraphQL.Schemas.Attendees.Mutations;
using ConferencePlanner.GraphQL.Schemas.Attendees.Queries;
using ConferencePlanner.GraphQL.Schemas.Attendees.Subscription;
using ConferencePlanner.GraphQL.Schemas.Sessions.Mutations;
using ConferencePlanner.GraphQL.Schemas.Sessions.Queries;
using ConferencePlanner.GraphQL.Schemas.Sessions.Subscriptions;
using ConferencePlanner.GraphQL.Schemas.Speakers.Mutations;
using ConferencePlanner.GraphQL.Schemas.Speakers.Queries;
using ConferencePlanner.GraphQL.Schemas.Tracks.Mutations;
using ConferencePlanner.GraphQL.Schemas.Tracks.Queries;
using ConferencePlanner.GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.GraphQL
{
    public class Startup
    {
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlite("Data Source=conferences.db")
            );

            services
                .AddGraphQLServer()
                .AddQueryType(d => d.Name("Query"))
                    .AddTypeExtension<AttendeeQuery>()
                    .AddTypeExtension<SpeakerQuery>()
                    .AddTypeExtension<SessionQuery>()
                    .AddTypeExtension<TrackQuery>()
                .AddMutationType(d => d.Name("Mutation"))
                    .AddTypeExtension<AttendeeMutation>()
                    .AddTypeExtension<SessionMutation>()
                    .AddTypeExtension<SpeakerMutation>()
                    .AddTypeExtension<TrackMutations>()
                .AddSubscriptionType(d => d.Name("Subscription"))
                    .AddTypeExtension<SessionSubscription>()
                    .AddTypeExtension<AttendeeSubscription>()
                .AddType<SpeakerType>()
                .AddType<AttendeeType>()
                .AddType<SessionType>()
                .AddType<TrackType>()
                .EnableRelaySupport()
                .AddFiltering()
                .AddSorting()
                .AddInMemorySubscriptions()
                .AddDataLoader<SpeakerByIdDataLoader>()
                .AddDataLoader<SessionByIdDataLoader>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseWebSockets();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}