using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok.Application.DTOs.User;
using Unitok.Application.Interfaces;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;

namespace Unitok.Infrastructure.Services
{
	public class UserService : IUserService
	{
		private readonly ApplicationDbContext _context;

		public UserService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<UserMain> GetUserProfileAsync(int userId)
		{
			return await _context.Users
				.Include(u => u.UserInfo)
				.FirstOrDefaultAsync(u => u.Id == userId);
		}


		public async Task UpdateUserProfileAsync(int userId, UserProfileDto dto)
		{
			var user = await _context.UserInfos.FindAsync(userId);
			if (user == null) throw new Exception("User not found");

			user.FirstName = dto.FirstName;
			user.LastName = dto.LastName;
			user.NickName = dto.NickName;
			user.Description = dto.Description;
			user.AvatarImageData = dto.AvatarImageData;
			user.BackgroundImageData = dto.BackgroundImageData;


			await _context.SaveChangesAsync();
		}
	}

}
