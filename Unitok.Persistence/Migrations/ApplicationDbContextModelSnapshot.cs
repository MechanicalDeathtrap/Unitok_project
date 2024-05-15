﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unitok_progect.Persistence.Contexts;

#nullable disable

namespace Unitok.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("NftCardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("StartingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("NftCardId")
                        .IsUnique();

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Bid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BidTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.HasIndex("UserId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Games"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Metaverses"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Domains"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Memes"
                        });
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.NftCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOnAuction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<bool>("isOnSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ImageId")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("NftCards");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.StaticFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Extension")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaticFiles");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvatarImageId")
                        .HasColumnType("int");

                    b.Property<int>("BackgroundImageId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FollowersNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WalletId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AvatarImageId")
                        .IsUnique();

                    b.HasIndex("BackgroundImageId")
                        .IsUnique();

                    b.HasIndex("WalletId");

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Earnings")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Auction", b =>
                {
                    b.HasOne("Unitok_progect.Domain.Entities.NftCard", "NftCard")
                        .WithOne("Auction")
                        .HasForeignKey("Unitok_progect.Domain.Entities.Auction", "NftCardId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("NftCard");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Bid", b =>
                {
                    b.HasOne("Unitok_progect.Domain.Entities.Auction", "Auction")
                        .WithMany("Bids")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unitok_progect.Domain.Entities.UserInfo", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.NftCard", b =>
                {
                    b.HasOne("Unitok_progect.Domain.Entities.Category", "Category")
                        .WithMany("NftCards")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Unitok_progect.Domain.Entities.UserInfo", "Creator")
                        .WithMany("NftCreatedCollection")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Unitok_progect.Domain.Entities.StaticFile", "Image")
                        .WithOne("Card")
                        .HasForeignKey("Unitok_progect.Domain.Entities.NftCard", "ImageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Unitok_progect.Domain.Entities.UserInfo", "Owner")
                        .WithMany("NftOnSaleCollection")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Creator");

                    b.Navigation("Image");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.UserInfo", b =>
                {
                    b.HasOne("Unitok_progect.Domain.Entities.StaticFile", "AvatarImage")
                        .WithOne()
                        .HasForeignKey("Unitok_progect.Domain.Entities.UserInfo", "AvatarImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unitok_progect.Domain.Entities.StaticFile", "BackgroundImage")
                        .WithOne()
                        .HasForeignKey("Unitok_progect.Domain.Entities.UserInfo", "BackgroundImageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Unitok_progect.Domain.Entities.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AvatarImage");

                    b.Navigation("BackgroundImage");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Auction", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.Category", b =>
                {
                    b.Navigation("NftCards");
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.NftCard", b =>
                {
                    b.Navigation("Auction")
                        .IsRequired();
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.StaticFile", b =>
                {
                    b.Navigation("Card")
                        .IsRequired();
                });

            modelBuilder.Entity("Unitok_progect.Domain.Entities.UserInfo", b =>
                {
                    b.Navigation("NftCreatedCollection");

                    b.Navigation("NftOnSaleCollection");
                });
#pragma warning restore 612, 618
        }
    }
}