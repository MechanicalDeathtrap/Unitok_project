using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unitok.Application.DTOs.User;
using Unitok.Application.Interfaces.Repositories;
using Unitok_progect.Domain.Entities;

namespace Unitok.Application.Features.Users.Commands.PostUserRegister
{
	public class UserRegisterCommand : IRequest<RegisterResult>
	{
		public UserRegisterDto Request { get; set; }
		public UserRegisterCommand(UserRegisterDto request)
		{
			Request = request;
		}
	}

	public class RegisterResult
	{
		public bool IsSuccess { get; set; }
		public List<string> Errors { get; set; } = new List<string>();
	}

	public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommand, RegisterResult>
	{
		private readonly SignInManager<UserMain> _signInManager;
		private readonly IGenericRepository<UserInfo> _userInfoRepository;
		private readonly UserManager<UserMain> _userManager;

		public UserRegisterCommandHandler(SignInManager<UserMain> signInManager, 
											IGenericRepository<UserInfo> userInfoRepository, UserManager<UserMain> userManager)
		{
			_signInManager = signInManager;
			_userInfoRepository = userInfoRepository;
			_userManager = userManager;
		}

		public async Task<RegisterResult> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
		{
			Console.WriteLine(request.Request.Name);

			if (request is null)
				throw new ArgumentNullException(nameof(request));

			if (string.IsNullOrEmpty(request.Request.Email))
				throw new ApplicationException("Email обязателен");

			if (string.IsNullOrEmpty(request.Request.Password))
				throw new ApplicationException("Password обязателен");

			if (string.IsNullOrWhiteSpace(request.Request.Name))
				throw new ApplicationException("Name обязателен");

			var UserInfo = new UserInfo
			{
				NickName = request.Request.Name,
				Email = request.Request.Email,
				Wallet = new Wallet
				{
					Earnings = 0
				}
			};

			var newUser = new UserMain
			{
				Email = request.Request.Email,
				UserName = request.Request.Name,
				UserInfo = UserInfo,
			};
			Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
			Console.WriteLine(newUser.UserInfo.Wallet.Earnings);

			//var result = await _signInManager.UserManager.CreateAsync(newUser, request.Request.Password);
			var result = await _userManager.CreateAsync(newUser, request.Request.Password);
			Console.WriteLine(result);

			if (!result.Succeeded)
			{
				return new RegisterResult
				{
					IsSuccess = false,
					Errors = result.Errors.Select(x => x.Description).ToList(),
				};
			}

			await _signInManager.SignInAsync(newUser, false);
			return new RegisterResult
			{
				IsSuccess = true,
				Errors = null
			};
		}
	}
}
