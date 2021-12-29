using System.ComponentModel.DataAnnotations;

namespace ConferencePlanner.GraphQL.Data.Models
{
    public class Track
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = default!;

        public ICollection<Session> Sessions { get; set; } = 
            new List<Session>();
    }
}