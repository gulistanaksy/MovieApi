using System;
using System.Collections.Generic;

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public int MovieId { get; set; }

        public GetMovieByIdQuery(int movieId)
        {
            MovieId = movieId;
        }
    }
}
