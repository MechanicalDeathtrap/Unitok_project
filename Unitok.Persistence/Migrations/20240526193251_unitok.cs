using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unitok.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class unitok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FollowersNumber = table.Column<int>(type: "int", nullable: false),
                    AvatarImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserInfoId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NftCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    isOnSale = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    IsOnAuction = table.Column<bool>(type: "bit", nullable: false),
                    AuctionId = table.Column<int>(type: "int", nullable: true),
                    UserInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NftCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NftCards_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NftCards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NftCards_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Earnings = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallets_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuctionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BidTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bids_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserInfoId", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "938c68bc-3b57-4bf3-9fb4-8020624d1da8", null, false, false, null, null, null, "AQAAAAIAAYagAAAAELJLW3CSx1yxpuvvG9zuJCa5quF1cLVOO/wkQpaUusTmb2JNLR8uYORWRi7YvZNovQ==", null, false, null, false, null, null },
                    { 2, 0, "21aa19d2-7017-47fe-8157-5fed89adb349", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEGSWv57E6mhZKhLgTLdIeGh032uRjAO+uJf8PTbxmcbD1h4DhyL7daTDaHPfyXdg/w==", null, false, null, false, null, null },
                    { 3, 0, "ad63f72c-4917-4060-bd75-603471de7a26", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEMLRcrKFlu91K9rkxGJoDDYquUWBVN2NBduC9lbkezBcc1199v/zOT72FsKBOHDdzg==", null, false, null, false, null, null },
                    { 4, 0, "16fea979-b776-4859-bd51-393ebe23b4ec", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEE+a2igrayd94WevI/0VPLEufEz4LpV2W+auMbTg6b85y/fB6kivrNM5phuVZGnNig==", null, false, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Art" },
                    { 2, "Photography" },
                    { 3, "Games" },
                    { 4, "Metaverses" },
                    { 5, "Music" },
                    { 6, "Domains" },
                    { 7, "Memes" }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "AvatarImageUrl", "BackgroundImageUrl", "CreatedBy", "CreatedDate", "Description", "Email", "FirstName", "FollowersNumber", "LastName", "NickName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "https://pristor.ru/wp-content/uploads/2019/08/%D0%9A%D0%B0%D1%80%D1%82%D0%B8%D0%BD%D0%BA%D0%B8-%D0%BD%D0%B0-%D0%B0%D0%B2%D1%83-%D0%B2-%D0%92%D0%9A-%D0%B4%D0%BB%D1%8F-%D0%B4%D0%B5%D0%B2%D1%83%D1%88%D0%B5%D0%BA-%D0%BA%D1%80%D1%83%D1%82%D1%8B%D0%B5-%D0%B8-%D0%BD%D0%B0%D1%80%D0%B8%D1%81%D0%BE%D0%B2%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5-21.jpg", null, null, null, "Моё величайшее хобби - digital art!", "user1@example.com", "Olivia", 0, "Martinez", "OlivMar", null, null },
                    { 2, "https://mykaleidoscope.ru/x/uploads/posts/2022-10/1666272848_46-mykaleidoscope-ru-p-krasavchik-otkritki-vkontakte-55.jpg", "https://2017com.xinnet.com/images/page3_bg_bot.jpg", null, null, "Создаю nft ради денег", "user2@example.com", "Koteki", 0, "Luchshie", "CatGod", null, null },
                    { 3, null, null, null, null, "Лень заполнять профиль", "user3@example.com", "Empty", 0, "EmptyX2", "Void", null, null },
                    { 4, "https://dashboard.gamaads.com/assets/images/reviews/1.jpg", "https://2017com.xinnet.com/images/page3_bg_bot.jpg", null, null, "Work! Work! Work!", "user4@example.com", "Alexey", 0, "Lobanov", "Ghost", null, null }
                });

            migrationBuilder.InsertData(
                table: "NftCards",
                columns: new[] { "Id", "AuctionId", "CategoryId", "CreatorId", "Description", "IsOnAuction", "Name", "OwnerId", "Price", "Url", "UserInfoId", "isOnSale" },
                values: new object[,]
                {
                    { 1, null, 1, 1, "A unique Batman NFT.", false, "Batman NFT", 1, 5m, "https://distribution.faceit-cdn.net/images/75fe87cc-b5d1-4f71-93cd-c2b9fe7af841.jpeg", null, false },
                    { 2, null, 2, 2, "A rare dragon NFT.", false, "Dragon NFT", 2, 7m, "https://i1.sndcdn.com/artworks-onlDHx9qCyyAiQKe-VN1gDg-t500x500.jpg", null, false },
                    { 3, null, 3, 3, "An exclusive anime girl NFT.", false, "Anime girl NFT", 3, 6m, "https://yt3.googleusercontent.com/ytc/AGIKgqPFf6TUkWcK-Rnc55WHy_VnMm2szMdQzn4gDpyc=s900-c-k-c0x00ffffff-no-rj", null, false },
                    { 4, null, 3, 1, "A creature NFT.", false, "Creature NFT", 3, 1m, "https://cryptogamingpool.com/wp-content/uploads/2019/04/1-2.png", null, false },
                    { 5, null, 4, 3, "An exclusive angel NFT.", false, "Angel NFT", 3, 3.1m, "https://avatars.steamstatic.com/ac270a27d12d0f861ce077ac1a629e55c55351f3_full.jpg", null, false },
                    { 6, null, 1, 1, "A really cool man NFT.", false, "Cool Man NFT", 1, 1.2m, "https://sun9-59.userapi.com/impg/UpcGRYwtgRL_kcPHGeD5NTsVmMa8aMdVWYsyLQ/bNLzvEk1XCw.jpg?size=720x720&quality=96&sign=97b6cdb8e8f71015f6bed868d89b363f&c_uniq_tag=k0LY6M1R0iv4A7eBylnKBHsFxyY7yioOrbpOdkksGHE&type=album", null, false },
                    { 7, null, 6, 2, "An exclusive abstract NFT.", false, "Abstract NFT", 2, 2.5m, "https://www.zonted.com/content/images/2021/01/finalfaces.jpg", null, false },
                    { 8, null, 3, 3, "An ordinary pixel girl NFT.", false, "Pixel girl NFT", 3, 1.1m, "https://steamuserimages-a.akamaihd.net/ugc/1841408372762079463/519B71A05D66A510E0D830144115136DBA8BED9B/?imw=512&amp;imh=512&amp;ima=fit&amp;impolicy=Letterbox&amp;imcolor=%23000000&amp;letterbox=true", null, false },
                    { 9, null, 7, 3, "Famous mem NFT.", false, "Mem NFT", 3, 0.8m, "https://images.squarespace-cdn.com/content/v1/613978bc7e5cf900cb25f3a9/84fc103a-9868-4bfe-9138-e033eee3670d/Screen+Shot+2022-04-27+at+8.46.08+PM.png", null, false },
                    { 10, null, 1, 1, "Really authetic NFT picture.", false, "Statue NFT", 1, 1m, "https://elearning.hse.ru/mirror/pubs/share/540771847", null, false }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Earnings", "UserInfoId" },
                values: new object[,]
                {
                    { 1, 100m, 1 },
                    { 2, 20m, 2 },
                    { 3, 37m, 3 },
                    { 4, 32m, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserInfoId",
                table: "AspNetUsers",
                column: "UserInfoId",
                unique: true,
                filter: "[UserInfoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_AuctionId",
                table: "Bids",
                column: "AuctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_UserId",
                table: "Bids",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NftCards_AuctionId",
                table: "NftCards",
                column: "AuctionId");

            migrationBuilder.CreateIndex(
                name: "IX_NftCards_CategoryId",
                table: "NftCards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NftCards_UserInfoId",
                table: "NftCards",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_UserInfoId",
                table: "Wallets",
                column: "UserInfoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "NftCards");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "UserInfos");
        }
    }
}
