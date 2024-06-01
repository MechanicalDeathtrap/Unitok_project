using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok.Application.DTOs.Bit
{
	public class GetBidDto
	{
		public int UserId { get; set; }
		public decimal Amount { get; set; }
		public DateTime BidTime { get; set; }
	}
}
