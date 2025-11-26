using System;

namespace API.W.Movies.DAL.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public string? Description { get; set; }
        public string Classification { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}