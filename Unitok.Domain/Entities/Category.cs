using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitok_progect.Domain.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public List<NftCard> NftCards { get; set; } = new List<NftCard>();
/*        public enum CategoryType
        {
            Art,
            Photography,
            Games,
            Metaverses,
            Nusic,
            Domains,
            Memes
        }*/
    }
}
