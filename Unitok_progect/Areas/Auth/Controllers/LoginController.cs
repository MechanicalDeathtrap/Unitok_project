using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Unitok.Application.DTOs.User;
using Unitok_progect.Domain.Entities;

namespace Unitok_project.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {

		private readonly SignInManager<UserMain> _signInManager;
		private readonly UserManager<UserMain> _userManager;
		private readonly ILogger<LoginController> _logger;

		public LoginController(SignInManager<UserMain> signInManager, UserManager<UserMain> userManager, ILogger<LoginController> logger)
		{
			_signInManager = signInManager;
			_userManager = userManager;
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View("Login");
		}

		[HttpPost]
		public async Task<IActionResult> Login(UserLoginDto model, string returnUrl = null)
		{
			_logger.LogInformation("Login attempt for user: {Email}", model.Email);

			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email);

				if (user != null)
				{
					_logger.LogInformation("Пользователь был найден: {UserName}, NormalizedEmail: {NormalizedEmail}, NormalizedUserName: {NormalizedUserName}",
						user.UserName, user.NormalizedEmail, user.NormalizedUserName);

					var isPasswordValid = await _userManager.CheckPasswordAsync(user, model.Password);
					if (isPasswordValid)
					{
						_logger.LogInformation("Пароль верный");

						var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

						_logger.LogInformation("SignInResult: Succeeded={Succeeded}, IsLockedOut={IsLockedOut}, IsNotAllowed={IsNotAllowed}, RequiresTwoFactor={RequiresTwoFactor}",
							result.Succeeded, result.IsLockedOut, result.IsNotAllowed, result.RequiresTwoFactor);

						if (result.Succeeded)
						{
							if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
							{
								return Redirect(returnUrl);
							}
							else
							{
								return RedirectToRoute("default", new { area = "", controller = "Home", action = "Index" });
							}
						}
						else
						{
							_logger.LogWarning("Ошибка логина. Result: Succeeded={Succeeded}, IsLockedOut={IsLockedOut}, IsNotAllowed={IsNotAllowed}, RequiresTwoFactor={RequiresTwoFactor}",
								result.Succeeded, result.IsLockedOut, result.IsNotAllowed, result.RequiresTwoFactor);

							ModelState.AddModelError(string.Empty, "Не удалось залогиниться. Попробуйте снова.");
						}
					}
					else
					{
						_logger.LogWarning("Invalid password for user: {UserName}", user.UserName);
						ModelState.AddModelError("Password", "Неправильный пароль или почта");
					}
				}
				else
				{
					_logger.LogWarning("User not found with email: {Email}", model.Email);
					ModelState.AddModelError("Email", "Пользователь с такой почтой не найден");
				}
			}
			else
			{
				_logger.LogWarning("Model state is invalid");
			}

			return View(model); // Возвращаем представление с моделью и ошибками
		}


		[HttpPost]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToRoute("default", new { area = "", controller = "Home", action = "Index" });
		}

	}
}
