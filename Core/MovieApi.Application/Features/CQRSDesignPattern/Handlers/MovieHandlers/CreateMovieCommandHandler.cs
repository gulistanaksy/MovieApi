
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _contex;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _contex = context;
        }
        public async Task Handle(CreateMovieCommand command)
        {
            _contex.Movies.Add(new Movie
            {
                CoverImageUrl = command.CoverImageUrl,
                CreatedYear = command.CreatedYear,
                Description = command.Description,
                Duration = command.Duration,
                Rating = command.Rating,
                ReleaseDate = command.ReleaseDate,
                Status = command.Status,
                Title=command.Title
            });
            await _contex.SaveChangesAsync();
        }

    }
}
