using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok_progect.Domain.Entities
{
    public class UserInfo: BaseEntity
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public int FollowersNumber { get; set; }
        public int AvatarImageId { get; set; }
        public  StaticFile? AvatarImage {  get; set; }
        public int BackgroundImageId { get; set; }
        public StaticFile? BackgroundImage { get; set; }
        public List<NftCard> NftCreatedCollection { get; set; } = new List<NftCard>();
        public List<NftCard> NftOnSaleCollection { get; set; } = new List<NftCard>();
        public Wallet Wallet { get; set; }
    }
}
