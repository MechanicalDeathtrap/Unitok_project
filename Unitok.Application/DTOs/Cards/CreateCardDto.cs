using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Unitok.Application.DTOs.Cards
{
	public class CreateCardDto
	{
		[Required(ErrorMessage = "Заполните поле!")]
		public IFormFile Image { get; set; }

		[Required(ErrorMessage = "Заполните поле!")]
		[MinLength(5, ErrorMessage = "Название должно содержать не менее 5 букв!")]
		[MaxLength(30, ErrorMessage = "Слишком длинное название (более 30 символов)")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Заполните поле!")]
		[MinLength(5, ErrorMessage = "Описание должно содержать по крайней мере 5 символов")]
		[MaxLength(200, ErrorMessage = "Слишком длинное описание (более 200 символов)")]
		public string Description { get; set; }
		[Required]
		public int Category { get; set; }
		[Required]
		public bool isOnAuction { get; set; }
		[Required]
		public bool isOnInstantSale { get; set; }
		[Required(ErrorMessage = "Заполните поле!")]
		//[Неправильный формат цены?????]
		public decimal Price { get; set; }
	}
}
