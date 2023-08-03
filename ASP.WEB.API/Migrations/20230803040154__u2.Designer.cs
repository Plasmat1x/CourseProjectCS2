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
    [Migration("20230803040154__u2")]
    partial class _u2
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
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6935),
                            Name = "oto",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6938),
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
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7052),
                            UserId = 2
                        },
                        new
                        {
                            OwnerId = 1,
                            Name = "Test",
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7054),
                            UserId = 3
                        },
                        new
                        {
                            OwnerId = 1,
                            Name = "Usver",
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7055),
                            UserId = 4
                        },
                        new
                        {
                            OwnerId = 2,
                            Name = "Admin",
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7056),
                            UserId = 1
                        },
                        new
                        {
                            OwnerId = 3,
                            Name = "Admin",
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(7057),
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
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6732),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6747),
                            Name = "Bobr"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6748),
                            Name = "Test"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6748),
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
                            AddedTime = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6959)
                        },
                        new
                        {
                            UserId = 2,
                            ChatId = 1,
                            AddedTime = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6960)
                        },
                        new
                        {
                            UserId = 3,
                            ChatId = 1,
                            AddedTime = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6962)
                        },
                        new
                        {
                            UserId = 4,
                            ChatId = 1,
                            AddedTime = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6963)
                        },
                        new
                        {
                            UserId = 1,
                            ChatId = 2,
                            AddedTime = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6964)
                        },
                        new
                        {
                            UserId = 2,
                            ChatId = 2,
                            AddedTime = new DateTime(2023, 8, 3, 11, 1, 54, 81, DateTimeKind.Local).AddTicks(6964)
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
