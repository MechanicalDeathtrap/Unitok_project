using Unitok_progect.Domain.Entities;

namespace Unitok_project.Areas.Explore.Models
{
    public class CardModel
    {
        public NftCard Card { get; set; }
        public List<NftCard> NftCards { get; set; }
        public UserInfo UserInfo { get; set; }
        public Auction CardAuction { get; set; }
    }
}
