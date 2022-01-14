﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hahaRU.Storage;

namespace hahaRU.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210515010056_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hahaRU.Storage.Entity.Anecdot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dislikes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DislikesCount")
                        .HasColumnType("int");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoSrc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Anecdots");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.AnecdotEnd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AnecdotEnds");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.AnecdotTexts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AnecdotTexts");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.Config", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.FunnyWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dislikes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DislikesCount")
                        .HasColumnType("int");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoSrc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FunnyWords");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.Mem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dislikes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DislikesCount")
                        .HasColumnType("int");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoSrc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mems");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.Permissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Permisions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dislikes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DislikesCount")
                        .HasColumnType("int");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteJoke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telegram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VkLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dislikes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DislikesCount")
                        .HasColumnType("int");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoSrc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.VideoSrc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoSrcs");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.memPictures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("memPictures");
                });

            modelBuilder.Entity("hahaRU.Storage.Entity.memText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("memTexts");
                });
#pragma warning restore 612, 618
        }
    }
}