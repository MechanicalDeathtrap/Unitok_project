using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Unitok_progect.Domain.Entities
{
    public class UserMain : IdentityUser<int>
    {
		//public int Id { get; set; }
		public int? UserInfoId { get; set; }
		public virtual UserInfo? UserInfo { get; set; }
		/*        public int Id {  get; set; }
				public UserInfo? UserInfo { get; set; }*/

	}
}
