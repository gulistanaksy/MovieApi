using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommmandHandler
    {
        private readonly MovieContext _contex;

        public RemoveCategoryCommmandHandler(MovieContext context)
        {
            _contex = context;
        }
        public async void Handle(RemoveCategoryCommand command)
        {
            var value = await _contex.Categories.FindAsync(command.CategoryId);
            _contex.Categories.Remove(value);
            await _contex.SaveChangesAsync();
        }

    }
}
