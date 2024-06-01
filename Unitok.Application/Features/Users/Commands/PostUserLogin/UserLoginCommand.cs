using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok.Application.DTOs.User;
using Unitok_progect.Domain.Entities;

namespace Unitok.Application.Features.Users.Commands.PostUserLogin
{
    public class UserLoginCommand : IRequest<bool>
    {
        public UserLoginDto Request { get; set; }
        public UserLoginCommand(UserLoginDto request)
        {
            Request = request;
        }
    }

    public class UserLoginCommandHandler : IRequestHandler<UserLoginCommand, bool>
    {
        private readonly SignInManager<UserMain> _signInManager;
        public UserLoginCommandHandler(SignInManager<UserMain> signInManager)
        {
            _signInManager = signInManager;
        }

        /// <inheritdoc/>
        public async Task<bool> Handle(UserLoginCommand command, CancellationToken cancellationToken)
        {
            var userByEmail = await _signInManager.UserManager.FindByEmailAsync(command.Request.Email);

            if (userByEmail is null)
                throw new ArgumentException("User by given email not found");

            var isPasswordCorrect =
                await _signInManager.PasswordSignInAsync(userByEmail, command.Request.Password, true, false);

            Console.WriteLine(isPasswordCorrect);

            return isPasswordCorrect.Succeeded;
        }
    }
}
