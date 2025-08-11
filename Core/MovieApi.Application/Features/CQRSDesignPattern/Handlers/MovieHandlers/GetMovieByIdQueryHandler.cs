using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _contex;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _contex = context;
        }
        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _contex.Movies.FindAsync(query.MovieId);
            return new GetMovieByIdQueryResult
            {
                MovieId = value.MovieId,
                Title = value.Title,
                CoverImageUrl = value.CoverImageUrl,
                Rating = value.Rating,
                Description = value.Description,
                Duration = value.Duration,
                ReleaseDate = value.ReleaseDate,
                CreatedYear = value.CreatedYear,
                Status = value.Status
            };
        }
    }
}
