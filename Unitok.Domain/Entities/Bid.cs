using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok_progect.Domain.Entities
{
    public class Bid : BaseEntity
    {
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
        public int UserId { get; set; }
        public UserInfo User { get; set; }
        public decimal Amount { get; set; }
        public DateTime BidTime { get; set; }
    }
}
