using ConferencePlanner.GraphQL.Data.Models;
using HotChocolate.Data.Filters;

namespace ConferencePlanner.GraphQL.Types
{
    public class SessionFilterInputType : FilterInputType<Session>
   {
      protected override void Configure(IFilterInputTypeDescriptor<Session> descriptor)
      {
            descriptor.Ignore(t => t.Id);
            descriptor.Ignore(t => t.TrackId);
      }
   }
}