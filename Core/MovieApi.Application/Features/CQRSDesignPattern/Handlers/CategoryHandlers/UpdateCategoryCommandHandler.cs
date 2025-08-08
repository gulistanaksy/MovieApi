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
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _contex;

        public UpdateCategoryCommandHandler(MovieContext context)
        {
            _contex = context;
        }
        public async void Handle(UpdateCategoryCommmand command)
        {
            var value = await _contex.Categories.FindAsync(command.CategoryId);
            value.CategoryName = command.CategoryName;
            await _contex.SaveChangesAsync();
        }

    }
}
