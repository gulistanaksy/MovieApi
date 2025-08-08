
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
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _contex;

        public RemoveMovieCommandHandler(MovieContext context)
        {
            _contex = context;
        }
        public async void Handle(RemoveMovieCommand command)
        {
            var value = await _contex.Movies.FindAsync(command.MovieId);
            _contex.Movies.Remove(value);
            await _contex.SaveChangesAsync();
        }

    }
}
