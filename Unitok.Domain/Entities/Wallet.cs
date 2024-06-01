using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok_progect.Domain.Entities
{
    public class Wallet: BaseEntity
    {
		public int Id { get; set; }
		public decimal Earnings { get; set; } = 0;
		public int UserInfoId { get; set; }
		public virtual UserInfo? UserInfo { get; set; }
		/*        public decimal Earnings { get; set; } = 0;
				public int UserInfoId { get; set; }
				public UserInfo? UserInfo { get; set; }*/
	}
}
