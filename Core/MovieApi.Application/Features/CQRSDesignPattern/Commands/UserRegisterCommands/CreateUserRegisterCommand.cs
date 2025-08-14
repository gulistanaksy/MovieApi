using MediatR;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands
{
    public class CreateUserRegisterCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}