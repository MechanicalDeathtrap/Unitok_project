using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok.Application.DTOs.User;
using Unitok_progect.Domain.Entities;

namespace Unitok.Application.Interfaces
{
	public interface IUserService
	{
		Task<UserMain> GetUserProfileAsync(int userId);
		Task UpdateUserProfileAsync(int userId, UserProfileDto dto);
	}

}
