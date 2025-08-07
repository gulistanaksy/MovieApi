using System;
using System.Collections.Generic;

namespace MovieApi.Domain.Entities
{
    public class Cast
    {
        public int CastId { get; set; }  // Primary key
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string? Overview { get; set; }
        public string? Biography { get; set; }

    }
}
