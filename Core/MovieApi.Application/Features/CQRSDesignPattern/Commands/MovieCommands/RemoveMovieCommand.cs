using System;
using System.Collections.Generic;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public int MovieId { get; set; }

    }
}
