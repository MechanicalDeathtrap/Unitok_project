using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unitok_progect.Domain.Entities
{
    public class NftCard: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public byte[]? ImageData { get; set; }
		public int OwnerId { get; set; }
		//public UserInfo? Owner { get; set; } 
        public int CreatorId { get; set; }
		//public UserInfo? Creator { get; set; }
        public bool isOnSale { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public bool IsOnAuction { get; set; }
        public int? AuctionId { get; set; }
        public Auction? Auction { get; set; }


        /*        public string Name { get; set; }
                public string? Description { get; set; }
                public StaticFile Image { get; set; }
                public UserInfo Owner { get; set; }
                public UserInfo Creator { get; set; }
                public bool isOnSale { get; set; }
                public decimal? Price { get; set; }
                public Category? Category { get; set; }
                public bool IsOnAuction { get; set; }*/
    }
}
