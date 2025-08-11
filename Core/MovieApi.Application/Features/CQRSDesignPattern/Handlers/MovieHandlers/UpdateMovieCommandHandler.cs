
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
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _contex;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _contex = context;
        }
        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _contex.Movies.FindAsync(command.MovieId);
            value.CoverImageUrl =command.CoverImageUrl;
            value.CreatedYear = command.Description;
            value.Description = command.Description;
            value.Duration = command.Duration;
            value.Rating = command.Rating;
            value.ReleaseDate = command.ReleaseDate;
            value.Status = command.Status;
            value.Title = command.Title;
            
            await _contex.SaveChangesAsync();
        }

    }
}
