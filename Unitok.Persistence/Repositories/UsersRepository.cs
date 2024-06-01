using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;

namespace Unitok.Persistence.Repositories
{
	public class UsersRepository
	{
		public List<UserInfo> Users { get; set; } = new List<UserInfo>();

		public UsersRepository()
		{
			Users = GetUsers().Result;
		}
		public async Task<List<UserInfo>> GetUsers()
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				return await db.UserInfos.ToListAsync();
			}
		}
	}
}
