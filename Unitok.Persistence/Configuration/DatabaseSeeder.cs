using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;
using static System.Net.WebRequestMethods;

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

		/*		public static IReadOnlyCollection<StaticFile> StaticFiles()
				{
					return new List<StaticFile>
					{

						,
						,
						,
						,
					 };

				}*/

		public static IReadOnlyCollection<Wallet> Wallets()
		{
			return new List<Wallet>
			{
				new Wallet { Id = 1, Earnings = 100, UserInfoId = 1 },
				 new Wallet { Id = 2, Earnings = 20 , UserInfoId = 2},
				 new Wallet { Id = 3, Earnings = 37 ,UserInfoId = 3 },
				 new Wallet { Id = 4, Earnings = 32, UserInfoId = 4}
			};
		}

		public static IReadOnlyCollection<UserInfo> UserInfos()
		{
			return new List<UserInfo>
			{
				new UserInfo { Id = 1, NickName = "OlivMar", Email = "user1@example.com", 
					FirstName = "Olivia", LastName = "Martinez" ,
					Description = "Моё величайшее хобби - digital art!",
					AvatarImageUrl = "https://pristor.ru/wp-content/uploads/2019/08/%D0%9A%D0%B0%D1%80%D1%82%D0%B8%D0%BD%D0%BA%D0%B8-%D0%BD%D0%B0-%D0%B0%D0%B2%D1%83-%D0%B2-%D0%92%D0%9A-%D0%B4%D0%BB%D1%8F-%D0%B4%D0%B5%D0%B2%D1%83%D1%88%D0%B5%D0%BA-%D0%BA%D1%80%D1%83%D1%82%D1%8B%D0%B5-%D0%B8-%D0%BD%D0%B0%D1%80%D0%B8%D1%81%D0%BE%D0%B2%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5-21.jpg"},
				new UserInfo { Id = 2, NickName = "CatGod", Email = "user2@example.com", 
					FirstName = "Koteki", LastName = "Luchshie" ,
					Description = "Создаю nft ради денег",
					AvatarImageUrl = "https://mykaleidoscope.ru/x/uploads/posts/2022-10/1666272848_46-mykaleidoscope-ru-p-krasavchik-otkritki-vkontakte-55.jpg",
					BackgroundImageUrl = "https://2017com.xinnet.com/images/page3_bg_bot.jpg",},
				new UserInfo { Id = 3, NickName = "Void", Email = "user3@example.com", FirstName = "Empty", LastName = "EmptyX2" , Description = "Лень заполнять профиль"},
				new UserInfo { Id = 4, NickName = "Ghost", Email = "user4@example.com",
					FirstName = "Alexey", LastName = "Lobanov" ,
					Description = "Work! Work! Work!",
					AvatarImageUrl = "https://dashboard.gamaads.com/assets/images/reviews/1.jpg",
					BackgroundImageUrl = "https://2017com.xinnet.com/images/page3_bg_bot.jpg",},
			};
		}

		public static IReadOnlyCollection<NftCard> NftCards()
		{
			return new List<NftCard>
			{
				new NftCard { Id = 1, Name = "Batman NFT", Description = "A unique Batman NFT.", Price = 5, CategoryId = 1, CreatorId = 1, OwnerId = 1 
				, Url = "https://distribution.faceit-cdn.net/images/75fe87cc-b5d1-4f71-93cd-c2b9fe7af841.jpeg" },
				new NftCard { Id = 2, Name = "Dragon NFT", Description = "A rare dragon NFT.", Price = 7,  CategoryId = 2, CreatorId = 2, OwnerId = 2 ,
				Url = "https://i1.sndcdn.com/artworks-onlDHx9qCyyAiQKe-VN1gDg-t500x500.jpg" },
				new NftCard { Id = 3, Name = "Anime girl NFT", Description = "An exclusive anime girl NFT.", Price = 6,  CategoryId = 3, CreatorId = 3, OwnerId = 3 ,
				Url = "https://yt3.googleusercontent.com/ytc/AGIKgqPFf6TUkWcK-Rnc55WHy_VnMm2szMdQzn4gDpyc=s900-c-k-c0x00ffffff-no-rj" },
				new NftCard { Id = 4, Name = "Creature NFT", Description = "A creature NFT.", Price = 1, CategoryId = 3, CreatorId = 1, OwnerId = 3 ,
				Url = "https://cryptogamingpool.com/wp-content/uploads/2019/04/1-2.png" },
				new NftCard { Id = 5, Name = "Angel NFT", Description = "An exclusive angel NFT.", Price = 3.1m,  CategoryId = 4, CreatorId = 3, OwnerId = 3 ,
				Url = "https://avatars.steamstatic.com/ac270a27d12d0f861ce077ac1a629e55c55351f3_full.jpg" },
				new NftCard { Id = 6, Name = "Cool Man NFT", Description = "A really cool man NFT.", Price = 1.2m,  CategoryId = 1, CreatorId = 1, OwnerId = 1 ,
				Url= "https://sun9-59.userapi.com/impg/UpcGRYwtgRL_kcPHGeD5NTsVmMa8aMdVWYsyLQ/bNLzvEk1XCw.jpg?size=720x720&quality=96&sign=97b6cdb8e8f71015f6bed868d89b363f&c_uniq_tag=k0LY6M1R0iv4A7eBylnKBHsFxyY7yioOrbpOdkksGHE&type=album" },
				new NftCard { Id = 7, Name = "Abstract NFT", Description = "An exclusive abstract NFT.", Price = 2.5m,  CategoryId = 6, CreatorId = 2, OwnerId = 2 ,
				Url = "https://www.zonted.com/content/images/2021/01/finalfaces.jpg" },
				new NftCard { Id = 8, Name = "Pixel girl NFT", Description = "An ordinary pixel girl NFT.", Price = 1.1m, CategoryId = 3, CreatorId = 3, OwnerId = 3 ,
				Url = "https://steamuserimages-a.akamaihd.net/ugc/1841408372762079463/519B71A05D66A510E0D830144115136DBA8BED9B/?imw=512&amp;imh=512&amp;ima=fit&amp;impolicy=Letterbox&amp;imcolor=%23000000&amp;letterbox=true" },
				new NftCard { Id = 9, Name = "Mem NFT", Description = "Famous mem NFT.", Price = 0.8m, CategoryId = 7, CreatorId = 3, OwnerId = 3 ,
					Url = "https://images.squarespace-cdn.com/content/v1/613978bc7e5cf900cb25f3a9/84fc103a-9868-4bfe-9138-e033eee3670d/Screen+Shot+2022-04-27+at+8.46.08+PM.png" },
				new NftCard { Id = 10, Name = "Statue NFT", Description = "Really authetic NFT picture.", Price = 1m,  CategoryId = 1, CreatorId = 1, OwnerId = 1 ,
				Url = "https://elearning.hse.ru/mirror/pubs/share/540771847"},
			};
		}


		public static IReadOnlyCollection<UserMain> Users(PasswordHasher<UserMain> passwordHasher)
		{
			var users = new List<UserMain>
			{
				new UserMain
				{
					Id = 1,
					//UserName = "user1",
					//NormalizedUserName = "USER1",
					//Email = "user1@example.com",
					//NormalizedEmail = "USER1@EXAMPLE.COM",
					//EmailConfirmed = true,
					PasswordHash = passwordHasher.HashPassword(null, "Password123!"),
					//SecurityStamp = Guid.NewGuid().ToString(),
				},
				new UserMain
				{
					Id = 2,
					//UserName = "user2",
					//NormalizedUserName = "USER2",
					//Email = "user2@example.com",
					//NormalizedEmail = "USER2@EXAMPLE.COM",
					//EmailConfirmed = true,
					PasswordHash = passwordHasher.HashPassword(null, "Password123!"),
					//SecurityStamp = Guid.NewGuid().ToString(),
				},
				new UserMain
				{
					Id = 3,
					//UserName = "user3",
					//NormalizedUserName = "USER3",
					//Email = "user3@example.com",
					//NormalizedEmail = "USER3@EXAMPLE.COM",
					//EmailConfirmed = true,
					PasswordHash = passwordHasher.HashPassword(null, "Password123!"),
					//SecurityStamp = Guid.NewGuid().ToString(),
				},
				new UserMain
				{
					Id = 4,
					//UserName = "user3",
					//NormalizedUserName = "USER3",
					//Email = "user3@example.com",
					//NormalizedEmail = "USER3@EXAMPLE.COM",
					//EmailConfirmed = true,
					PasswordHash = passwordHasher.HashPassword(null, "Password123!"),
					//SecurityStamp = Guid.NewGuid().ToString(),
				}
			};

			return users;
		}

	}
}
