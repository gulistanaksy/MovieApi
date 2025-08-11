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
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _contex;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _contex = context;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            _contex.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });
            await _contex.SaveChangesAsync();
        }

    }
}
