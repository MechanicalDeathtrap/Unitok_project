using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Unitok.Application.DTOs.User;
using Unitok.Application.Features.Users.Commands.PostUserRegister;
using Microsoft.AspNetCore.Identity;
using Unitok_progect.Domain.Entities;
using Azure.Core;
using CleanArchitectureDemo.Application.Interfaces;

namespace Unitok_progect.Areas.Register.Controllers
{
	[Area("Auth")]
	public class RegisterController : Controller
	{
		private readonly UserManager<UserMain> _userManager;
		private readonly SignInManager<UserMain> _signInManager;
		private readonly ILogger<RegisterController> _logger;
		private readonly IEmailSender _emailSender;

		public RegisterController(UserManager<UserMain> userManager, SignInManager<UserMain> signInManager, ILogger<RegisterController> logger, IEmailSender emailSender)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_logger = logger;
			_emailSender = emailSender;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View("Register");
		}

		[HttpPost]
		public async Task<IActionResult> Register(UserRegisterDto model)
		{
			if (ModelState.IsValid)
			{
				_logger.LogInformation("Модель валидна, создаем пользователя");

				if (model is null)
					throw new ArgumentNullException(nameof(model));

				// Проверка существующего ника
				var existingUserByName = await _userManager.FindByNameAsync(model.Name);
				if (existingUserByName != null)
				{
					ModelState.AddModelError("Name", "Такой ник уже существует");
				}

				// Проверка существующего email
				var existingUserByEmail = await _userManager.FindByEmailAsync(model.Email);
				if (existingUserByEmail != null)
				{
					ModelState.AddModelError("Email", "Такая почта уже существует");
				}

				if (ModelState.ErrorCount > 0)
				{
					return View(model);
				}

				var wallet = new Wallet
				{
					Earnings = 2
				};

				var userInfo = new UserInfo
				{
					NickName = model.Name,
					Email = model.Email,
					Wallet = wallet
				};

				wallet.UserInfo = userInfo;

				var user = new UserMain
				{
					UserName = model.Name,
					Email = model.Email,
					NormalizedEmail = model.Email.ToUpper(),
					NormalizedUserName = model.Name.ToUpper(),
					UserInfo = userInfo,
					EmailConfirmed = true
				};


				var result = await _userManager.CreateAsync(user, model.Password);

				if (!result.Succeeded)
				{
					_logger.LogWarning("Не удалось создать пользователя. Ошибки: {Errors}", string.Join(", ", result.Errors.Select(e => e.Description)));

					return View(model);
				}

				_logger.LogInformation("Пользователь создан");

				await _signInManager.SignInAsync(user, isPersistent: false);
				return RedirectToRoute("default", new { area = "", controller = "Home", action = "Index" });
			}

			return View(model);
		}

		/*		[HttpPost]
				public async Task<IActionResult> Register(UserRegisterDto model)
				{
					if (ModelState.IsValid)
					{
						_logger.LogInformation("Model state is valid. Proceeding with user creation.");

						if (model is null)
							throw new ArgumentNullException(nameof(model));



						var wallet = new Wallet
						{
							Earnings = 2
						};

						var userInfo = new UserInfo
						{
							NickName = model.Name,
							Email = model.Email,
							Wallet = wallet
						};

						wallet.UserInfo = userInfo;

						var user = new UserMain
						{
							UserName = model.Name,
							Email = model.Email,
							NormalizedEmail = model.Email.ToUpper(),
							NormalizedUserName = model.Name.ToUpper(),
							UserInfo = userInfo,
							EmailConfirmed = true
						};

						_logger.LogInformation("Creating user with email: {Email}", model.Email);


						var result = await _userManager.CreateAsync(user, model.Password);

						if (!result.Succeeded)
						{
							_logger.LogWarning("User creation failed. Errors: {Errors}", string.Join(", ", result.Errors.Select(e => e.Description)));

							foreach (var error in result.Errors)
							{
								ModelState.AddModelError(string.Empty, error.Description);
							}
							//return RedirectToAction("");
							return Redirect("/Auth/Register/Register");
						}

						_logger.LogInformation("User created successfully. Signing in.");

		*//*				var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
						var confirmationLink = Url.Action("ConfirmEmail", "Auth", new { userId = user.Id, token = token }, Request.Scheme);
						await _emailSender.SendEmailAsync(model.Email, "Confirm your email", $"Please confirm your email by clicking <a href='{confirmationLink}'>here</a>");
		*//*

						await _signInManager.SignInAsync(user, isPersistent: false);
						return RedirectToRoute("default", new { area = "", controller = "Home", action = "Index" });

					}
					return View();
					//return View(model);
				}
		*/
	}
}
