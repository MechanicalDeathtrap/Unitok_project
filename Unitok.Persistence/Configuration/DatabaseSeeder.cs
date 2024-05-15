using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;

namespace Unitok_progect.Persistence.Configuration
{
    public class DatabaseSeeder
    {
        public DatabaseSeeder() { }

        public static IReadOnlyCollection<Category> Categories()
        {
            return new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Art",
                },
                new Category
                {
                    Id = 2,
                    Name = "Photography",
                },
                new Category
                {
                    Id = 3,
                    Name = "Games",
                },
                new Category
                {
                    Id = 4,
                    Name = "Metaverses",
                },
                new Category
                {
                    Id = 5,
                    Name = "Music",
                },
                new Category
                {
                    Id = 6,
                    Name = "Domains",
                },
                new Category
                {
                    Id = 7,
                    Name = "Memes",
                }
            };
        }

        /*            return new List<NftCard>
                    {
                        new NftCard
                        {
                            Id = 1,
                            Name = ''
                        },
                    };*/

/*        public static IReadOnlyCollection<StaticFile> StaticFiles()
        {
            return new List<StaticFile>
            {
                new StaticFile
                {
                    Id = 1,
                    Name = "batman.jpeg",
                    Path = "https://distribution.faceit-cdn.net/images/75fe87cc-b5d1-4f71-93cd-c2b9fe7af841.jpeg"
                },
                new StaticFile
                {
                    Id = 2,
                    Name = "dragon.jpg",
                    Path = "https://i1.sndcdn.com/artworks-onlDHx9qCyyAiQKe-VN1gDg-t500x500.jpg"
                },
                new StaticFile
                {
                    Id = 3,
                    Name = "anime-girl.jpg",
                    Path = "https://yt3.googleusercontent.com/ytc/AGIKgqPFf6TUkWcK-Rnc55WHy_VnMm2szMdQzn4gDpyc=s900-c-k-c0x00ffffff-no-rj"
                },
            };

        }*/
    }
}
