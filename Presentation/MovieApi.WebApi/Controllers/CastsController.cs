using Microsoft.AspNetCore.Mvc;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;

namespace MovieApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public IActionResult CastList()
        {
            var value = _mediator.Send(new GetCastQuery());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCast(CreateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Cast created successfully");
        }
        [HttpDelete]
        public IActionResult DeleteCast(int id)
        {
            _mediator.Send(new RemoveCastCommand(id));
            return Ok("Cast deleted successfully");
        }
        [HttpGet("GetCastById")]
        public IActionResult GetCastById(int id)
        {
            var value = _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCast(UpdateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Cast updated successfully");
        }
    }
}