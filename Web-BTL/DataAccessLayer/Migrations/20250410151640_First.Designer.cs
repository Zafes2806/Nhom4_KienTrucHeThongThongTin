﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_BTL.DataAccessLayer;



#nullable disable

namespace Web_BTL.Migrations {
    [DbContext(typeof(DBXemPhimContext))]
    [Migration("20250410151640_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Media_Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "MediaId");

                    b.HasIndex("MediaId");

                    b.ToTable("Media_Genre");
                });

            modelBuilder.Entity("Web_BTL.Models.Actors.Actor_MediaModel", b =>
                {
                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.HasKey("MediaId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("Actor_Medias");
                });

            modelBuilder.Entity("Web_BTL.Models.Actors.ActorModel", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorID"), 1L, 1);

                    b.Property<DateTime?>("AcctorDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Web_BTL.Models.ListMedia.Watch.ListMediaModel", b =>
                {
                    b.Property<int?>("WatchListId")
                        .HasColumnType("int");

                    b.Property<int?>("MediaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Favorite")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsWatched")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("WatchListId", "MediaId");

                    b.HasIndex("MediaId");

                    b.ToTable("ListMedia");
                });

            modelBuilder.Entity("Web_BTL.Models.ListMedia.Watch.WatchListModel", b =>
                {
                    b.Property<int>("WatchListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WatchListId"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("WatchListId");

                    b.ToTable("WatchLists");
                });

            modelBuilder.Entity("Web_BTL.Models.Medias.GenreModel", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Web_BTL.Models.Medias.MediaModel", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaId"), 1L, 1);

                    b.Property<int?>("MediaAgeRating")
                        .HasColumnType("int");

                    b.Property<string>("MediaBannerPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("MediaDuration")
                        .HasColumnType("time");

                    b.Property<string>("MediaImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("package")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaId");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("Web_BTL.Models.ReviewModel", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReviewCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("ReviewRating")
                        .HasColumnType("float");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MediaId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Web_BTL.Models.User.Admin.AdminModel", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("LoginPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UserCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("UserDuration")
                        .HasColumnType("time");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("UserState")
                        .HasColumnType("bit");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Web_BTL.Models.User.Customer.CustomerModel", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<int?>("FavoriteListId")
                        .HasColumnType("int");

                    b.Property<int?>("HistoryListId")
                        .HasColumnType("int");

                    b.Property<string>("LoginPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UserCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("UserDuration")
                        .HasColumnType("time");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("UserState")
                        .HasColumnType("bit");

                    b.Property<int?>("WatchListId")
                        .HasColumnType("int");

                    b.Property<string>("_ServicePackage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("WatchListId")
                        .IsUnique()
                        .HasFilter("[WatchListId] IS NOT NULL");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Media_Genre", b =>
                {
                    b.HasOne("Web_BTL.Models.Medias.GenreModel", null)
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_BTL.Models.Medias.MediaModel", null)
                        .WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Web_BTL.Models.Actors.Actor_MediaModel", b =>
                {
                    b.HasOne("Web_BTL.Models.Actors.ActorModel", "Actor")
                        .WithMany("Medias")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_BTL.Models.Medias.MediaModel", "Media")
                        .WithMany("Actors")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Media");
                });

            modelBuilder.Entity("Web_BTL.Models.ListMedia.Watch.ListMediaModel", b =>
                {
                    b.HasOne("Web_BTL.Models.Medias.MediaModel", "media")
                        .WithMany("WatchLists")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_BTL.Models.ListMedia.Watch.WatchListModel", "watchList")
                        .WithMany("Medias")
                        .HasForeignKey("WatchListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("media");

                    b.Navigation("watchList");
                });

            modelBuilder.Entity("Web_BTL.Models.ReviewModel", b =>
                {
                    b.HasOne("Web_BTL.Models.User.Customer.CustomerModel", "UserModel")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_BTL.Models.Medias.MediaModel", "Medias")
                        .WithMany("Reviews")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medias");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Web_BTL.Models.User.Customer.CustomerModel", b =>
                {
                    b.HasOne("Web_BTL.Models.ListMedia.Watch.WatchListModel", "WatchList")
                        .WithOne("User")
                        .HasForeignKey("Web_BTL.Models.User.Customer.CustomerModel", "WatchListId");

                    b.Navigation("WatchList");
                });

            modelBuilder.Entity("Web_BTL.Models.Actors.ActorModel", b =>
                {
                    b.Navigation("Medias");
                });

            modelBuilder.Entity("Web_BTL.Models.ListMedia.Watch.WatchListModel", b =>
                {
                    b.Navigation("Medias");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Web_BTL.Models.Medias.MediaModel", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Reviews");

                    b.Navigation("WatchLists");
                });

            modelBuilder.Entity("Web_BTL.Models.User.Customer.CustomerModel", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
