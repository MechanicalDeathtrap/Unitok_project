using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok.Application.DTOs.User
{
    public class UserRegisterDto
    {
        [EmailAddress]
        [Required(ErrorMessage = "Заполните поле!")]
		[RegularExpression(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$", ErrorMessage = "Не валидная почта")]
		public string Email { get; set; }

        [Required(ErrorMessage = "Заполните поле!")]
        [MaxLength(25, ErrorMessage = "Имя не должно превышать 25 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Заполните поле!")] 
        [MinLength(8, ErrorMessage = "Пароль не должен быть меньше 8 символов")]
		[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$", ErrorMessage = "Не валидный пароль")]
		public string Password { get; set; }
    }
}
