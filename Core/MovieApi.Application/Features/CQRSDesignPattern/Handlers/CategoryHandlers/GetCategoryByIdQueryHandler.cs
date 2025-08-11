using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.CategoryQueries;
using MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieContext _contex;

        public GetCategoryByIdQueryHandler(MovieContext context)
        {
            _contex = context;
        }
        public async Task<GetCategoryByIdResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _contex.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName,
            };
        }

    }
}
