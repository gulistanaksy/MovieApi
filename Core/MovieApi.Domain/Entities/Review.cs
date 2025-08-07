using System;
using System.Collections.Generic;

namespace MovieApi.Domain.Entities
{
    // yorumlar
    public class Review
    {
        public int ReviewId { get; set; }  // Primary key
        public string ReviewComment { get; set; }
        public int UserRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool Status { get; set; }

    }
}
