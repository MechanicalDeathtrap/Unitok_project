using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unitok_progect.Domain.Entities
{
    public class Auction : BaseEntity
    {
        public int Id { get; set; }
        //public int NftCardId { get; set; }
        //public NftCard NftCard { get; set; }
        public decimal StartingPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Bid> Bids { get; set; } = new List<Bid>();
        public bool IsActive => DateTime.UtcNow >= StartTime && DateTime.UtcNow <= EndTime;
        public bool IsCompleted => DateTime.UtcNow > EndTime;
    }
}
