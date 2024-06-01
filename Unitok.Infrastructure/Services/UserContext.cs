using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Unitok.Application.Interfaces;

namespace Unitok.Infrastructure.Services
{
	public class UserContext : IUserContext
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		public UserContext(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		/// <inheritdoc />
		public Guid? CurrentUserId =>
			Guid.TryParse(User?.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value, out var userId)
				? userId
				: null;

		private ClaimsPrincipal? User => _httpContextAccessor.HttpContext?.User;
	}
}
