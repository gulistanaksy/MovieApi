using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    
    //  GetCastQuery → gelen istek tipi
    // List<GetCastQueryResult> → bu isteğin döneceği cevap tipi (cast listesi)
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext _context;

        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(c => new GetCastQueryResult
            {
                CastId = c.CastId,
                Title = c.Title,
                Name = c.Name,
                Surname = c.Surname,
                ImageUrl = c.ImageUrl,
                Overview = c.Overview,
                Biography = c.Biography
            }).ToList();
        }
    }
}