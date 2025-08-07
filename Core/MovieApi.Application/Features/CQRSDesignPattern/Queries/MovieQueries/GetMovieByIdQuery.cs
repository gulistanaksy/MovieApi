using System;
using System.Collections.Generic;

namespace MovieApi.Application.Features.CQRSDesignPattern.Query.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public int MovieId { get; set; }
    }
}
