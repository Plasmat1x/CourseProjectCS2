﻿// <auto-generated />
using System;
using ASP.WEB.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.WEB.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230803035718__u1")]
    partial class _u1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Chats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9079),
                            Name = "oto",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9083),
                            Name = "ptp",
                            OwnerId = 2
                        });
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.Contact", b =>
                {
                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OwnerId", "Name");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            OwnerId = 1,
                            Name = "Bobr",
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9130),
                            UserId = 2
                        },
                        new
                        {
                            OwnerId = 2,
                            Name = "Admin",
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9132),
                            UserId = 1
                        },
                        new
                        {
                            OwnerId = 3,
                            Name = "Admin",
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9134),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8905),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8918),
                            Name = "Bobr"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8919),
                            Name = "Test"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(8920),
                            Name = "Usver"
                        });
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.UserChat", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "ChatId");

                    b.HasIndex("ChatId");

                    b.ToTable("UserChats");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ChatId = 1,
                            AddedTime = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9103)
                        },
                        new
                        {
                            UserId = 2,
                            ChatId = 1,
                            AddedTime = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9105)
                        },
                        new
                        {
                            UserId = 3,
                            ChatId = 1,
                            AddedTime = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9106)
                        },
                        new
                        {
                            UserId = 4,
                            ChatId = 1,
                            AddedTime = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9107)
                        },
                        new
                        {
                            UserId = 1,
                            ChatId = 2,
                            AddedTime = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9108)
                        },
                        new
                        {
                            UserId = 2,
                            ChatId = 2,
                            AddedTime = new DateTime(2023, 8, 3, 10, 57, 18, 807, DateTimeKind.Local).AddTicks(9109)
                        });
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.Chat", b =>
                {
                    b.HasOne("ASP.WEB.API.Context.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.Contact", b =>
                {
                    b.HasOne("ASP.WEB.API.Context.Entities.User", "Owner")
                        .WithMany("Contacts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ASP.WEB.API.Context.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.UserChat", b =>
                {
                    b.HasOne("ASP.WEB.API.Context.Entities.Chat", "Chat")
                        .WithMany("UserChats")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ASP.WEB.API.Context.Entities.User", "User")
                        .WithMany("UserChats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.Chat", b =>
                {
                    b.Navigation("UserChats");
                });

            modelBuilder.Entity("ASP.WEB.API.Context.Entities.User", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("UserChats");
                });
#pragma warning restore 612, 618
        }
    }
}
