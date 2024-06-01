using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok.Application.DTOs.User
{
    public class UserLoginDto
    {
        [EmailAddress] 
        [Required(ErrorMessage = "Заполните поле!")]
		[RegularExpression(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$", ErrorMessage = "Не валидная почта")]
		public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Заполните поле!")]
		[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$", ErrorMessage = "Не валидный пароль")]
		public string Password { get; set; } = null!;

		[Required(ErrorMessage = "Заполните поле!")]
		public bool RememberMe { get; set; }
	}
}
