﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WorkersWages.API.Storage;

namespace WorkersWages.API.Storage.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("workers_wages")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Allowance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WageId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WageId");

                    b.ToTable("Allowances");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Manufactory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HeadFIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("HeadPhotoId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("HeadPhotoId");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Manufactories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            HeadFIO = "Пупкин Арсений Викторович",
                            Name = "Цех #1",
                            Number = "1",
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Professions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            Name = "Слесарь",
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            Name = "Токарь",
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            Name = "Сварщик",
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ProfessionId")
                        .HasColumnType("integer");

                    b.Property<int>("Rank")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId", "Rank")
                        .IsUnique();

                    b.ToTable("Salaries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 100.0,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ProfessionId = 1,
                            Rank = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            Amount = 200.0,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ProfessionId = 1,
                            Rank = 2,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3,
                            Amount = 250.0,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ProfessionId = 1,
                            Rank = 3,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 4,
                            Amount = 150.0,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ProfessionId = 2,
                            Rank = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 5,
                            Amount = 200.0,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ProfessionId = 2,
                            Rank = 2,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 6,
                            Amount = 200.0,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ProfessionId = 3,
                            Rank = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        },
                        new
                        {
                            Id = 7,
                            Amount = 300.0,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ProfessionId = 3,
                            Rank = 2,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<TimeSpan?>("BreakEnd")
                        .HasColumnType("interval");

                    b.Property<TimeSpan?>("BreakStart")
                        .HasColumnType("interval");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ManufactoryId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WeekDay")
                        .HasColumnType("integer");

                    b.Property<TimeSpan?>("WorkingEnd")
                        .HasColumnType("interval");

                    b.Property<TimeSpan?>("WorkingStart")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("ManufactoryId", "WeekDay")
                        .IsUnique();

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BreakEnd = new TimeSpan(0, 13, 0, 0, 0),
                            BreakStart = new TimeSpan(0, 12, 0, 0, 0),
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ManufactoryId = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            WeekDay = 0,
                            WorkingEnd = new TimeSpan(0, 17, 30, 0, 0),
                            WorkingStart = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            BreakEnd = new TimeSpan(0, 13, 0, 0, 0),
                            BreakStart = new TimeSpan(0, 12, 0, 0, 0),
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ManufactoryId = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            WeekDay = 1,
                            WorkingEnd = new TimeSpan(0, 17, 30, 0, 0),
                            WorkingStart = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            BreakEnd = new TimeSpan(0, 13, 0, 0, 0),
                            BreakStart = new TimeSpan(0, 12, 0, 0, 0),
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ManufactoryId = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            WeekDay = 2,
                            WorkingEnd = new TimeSpan(0, 17, 30, 0, 0),
                            WorkingStart = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            BreakEnd = new TimeSpan(0, 13, 0, 0, 0),
                            BreakStart = new TimeSpan(0, 12, 0, 0, 0),
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ManufactoryId = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            WeekDay = 3,
                            WorkingEnd = new TimeSpan(0, 17, 30, 0, 0),
                            WorkingStart = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            BreakEnd = new TimeSpan(0, 13, 0, 0, 0),
                            BreakStart = new TimeSpan(0, 12, 0, 0, 0),
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ManufactoryId = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            WeekDay = 4,
                            WorkingEnd = new TimeSpan(0, 17, 30, 0, 0),
                            WorkingStart = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ManufactoryId = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            WeekDay = 5
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            ManufactoryId = 1,
                            Updated = new DateTimeOffset(new DateTime(2022, 4, 11, 22, 34, 38, 964, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 4, 0, 0, 0)),
                            WeekDay = 6
                        });
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<int?>("ReloadDataTime")
                        .HasColumnType("integer");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Wage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ManufactoryId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfessionId")
                        .HasColumnType("integer");

                    b.Property<int>("Rank")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WorkerLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ManufactoryId");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("WorkerLastName")
                        .IsUnique();

                    b.ToTable("Wages");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkersWages.API.Storage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Allowance", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.Wage", "Wage")
                        .WithMany()
                        .HasForeignKey("WageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wage");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Manufactory", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.File", "HeadPhoto")
                        .WithMany()
                        .HasForeignKey("HeadPhotoId");

                    b.Navigation("HeadPhoto");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Salary", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Schedule", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.Manufactory", "Manufactory")
                        .WithMany()
                        .HasForeignKey("ManufactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufactory");
                });

            modelBuilder.Entity("WorkersWages.API.Storage.Models.Wage", b =>
                {
                    b.HasOne("WorkersWages.API.Storage.Models.Manufactory", "Manufactory")
                        .WithMany()
                        .HasForeignKey("ManufactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkersWages.API.Storage.Models.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufactory");

                    b.Navigation("Profession");
                });
#pragma warning restore 612, 618
        }
    }
}
