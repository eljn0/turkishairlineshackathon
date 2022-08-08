﻿// <auto-generated />
using System;
using BaggageTracking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaggageTracking.Migrations
{
    [DbContext(typeof(BaggageDbContext))]
    partial class BaggageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("BaggageTracking.Models.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HEYDAR ALIYEV INTERNATIONAL AIRPORT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ataturk Airport"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Antalya Airport"
                        });
                });

            modelBuilder.Entity("BaggageTracking.Models.Baggage", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IsOutId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LandedId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoadingId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OutPlatformId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IsOutId");

                    b.HasIndex("LandedId");

                    b.HasIndex("LoadingId");

                    b.HasIndex("OutPlatformId");

                    b.ToTable("Baggages");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            IsOutId = 1,
                            LandedId = 1,
                            LoadingId = 1,
                            Weight = 26.56f
                        },
                        new
                        {
                            Id = 4,
                            IsOutId = 1,
                            LandedId = 1,
                            LoadingId = 1,
                            Weight = 26.56f
                        },
                        new
                        {
                            Id = 5,
                            IsOutId = 1,
                            LandedId = 1,
                            LoadingId = 1,
                            Weight = 26.56f
                        },
                        new
                        {
                            Id = 6,
                            IsOutId = 1,
                            LandedId = 1,
                            LoadingId = 2,
                            Weight = 26.56f
                        },
                        new
                        {
                            Id = 7,
                            IsOutId = 1,
                            LandedId = 2,
                            LoadingId = 3,
                            Weight = 26.56f
                        },
                        new
                        {
                            Id = 8,
                            IsOutId = 1,
                            LandedId = 2,
                            LoadingId = 3,
                            Weight = 26.56f
                        },
                        new
                        {
                            Id = 9,
                            IsOutId = 2,
                            LandedId = 3,
                            LoadingId = 3,
                            Weight = 26.56f
                        },
                        new
                        {
                            Id = 10,
                            IsOutId = 3,
                            LandedId = 3,
                            LoadingId = 3,
                            OutPlatformId = 7,
                            Weight = 26.56f
                        });
                });

            modelBuilder.Entity("BaggageTracking.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AirportId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BaggageOutPoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AirportId");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AirportId = 1,
                            BaggageOutPoint = "Comes to A1 platform",
                            Name = "A1"
                        },
                        new
                        {
                            Id = 2,
                            AirportId = 1,
                            BaggageOutPoint = "Comes to B1 platform",
                            Name = "B1"
                        },
                        new
                        {
                            Id = 3,
                            AirportId = 1,
                            BaggageOutPoint = "Comes to A2 platform",
                            Name = "A2"
                        },
                        new
                        {
                            Id = 4,
                            AirportId = 1,
                            BaggageOutPoint = "Comes to B2 platform",
                            Name = "B2"
                        },
                        new
                        {
                            Id = 5,
                            AirportId = 1,
                            BaggageOutPoint = "Comes to C1 platform",
                            Name = "C1"
                        },
                        new
                        {
                            Id = 6,
                            AirportId = 1,
                            BaggageOutPoint = "Comes to C2 platform",
                            Name = "C2"
                        },
                        new
                        {
                            Id = 7,
                            AirportId = 2,
                            BaggageOutPoint = "Comes to A1 platform",
                            Name = "A1"
                        },
                        new
                        {
                            Id = 8,
                            AirportId = 2,
                            BaggageOutPoint = "Comes to B1 platform",
                            Name = "B1"
                        },
                        new
                        {
                            Id = 9,
                            AirportId = 2,
                            BaggageOutPoint = "Comes to A2 platform",
                            Name = "A2"
                        },
                        new
                        {
                            Id = 10,
                            AirportId = 2,
                            BaggageOutPoint = "Comes to B2 platform",
                            Name = "B2"
                        },
                        new
                        {
                            Id = 11,
                            AirportId = 2,
                            BaggageOutPoint = "Comes to C1 platform",
                            Name = "C1"
                        },
                        new
                        {
                            Id = 12,
                            AirportId = 2,
                            BaggageOutPoint = "Comes to C2 platform",
                            Name = "C2"
                        },
                        new
                        {
                            Id = 13,
                            AirportId = 3,
                            BaggageOutPoint = "Comes to A1 platform",
                            Name = "A1"
                        },
                        new
                        {
                            Id = 14,
                            AirportId = 3,
                            BaggageOutPoint = "Comes to B1 platform",
                            Name = "B1"
                        },
                        new
                        {
                            Id = 15,
                            AirportId = 3,
                            BaggageOutPoint = "Comes to A2 platform",
                            Name = "A2"
                        },
                        new
                        {
                            Id = 16,
                            AirportId = 3,
                            BaggageOutPoint = "Comes to B2 platform",
                            Name = "B2"
                        },
                        new
                        {
                            Id = 17,
                            AirportId = 3,
                            BaggageOutPoint = "Comes to C1 platform",
                            Name = "C1"
                        },
                        new
                        {
                            Id = 18,
                            AirportId = 3,
                            BaggageOutPoint = "Comes to C2 platform",
                            Name = "C2"
                        });
                });

            modelBuilder.Entity("BaggageTracking.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassName = "btn-secondary",
                            Icon = "fa-solid fa-hand",
                            Name = "Waiting"
                        },
                        new
                        {
                            Id = 2,
                            ClassName = "btn-warning",
                            Icon = "fa-solid fa-spinner fa-spin",
                            Name = "Expected"
                        },
                        new
                        {
                            Id = 3,
                            ClassName = "btn-success",
                            Icon = "fa-solid fa-circle-check",
                            Name = "Success"
                        });
                });

            modelBuilder.Entity("BaggageTracking.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FlyCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FlyDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("FromAirportId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ToAirportId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FromAirportId");

                    b.HasIndex("ToAirportId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FlyCode = "ASCSDDF11223232",
                            FlyDate = new DateTime(2022, 8, 9, 4, 52, 54, 936, DateTimeKind.Local).AddTicks(775),
                            FromAirportId = 1,
                            Name = "Orxan Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 2,
                            FlyCode = "ASCSEEF11223232",
                            FlyDate = new DateTime(2022, 8, 9, 4, 52, 54, 936, DateTimeKind.Local).AddTicks(783),
                            FromAirportId = 1,
                            Name = "Əli Ocaqverdiyev",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 3,
                            FlyCode = "DDCSDDF11223232",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(785),
                            FromAirportId = 1,
                            Name = "Ehmed Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 4,
                            FlyCode = "VVCSDDF11223232",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(787),
                            FromAirportId = 1,
                            Name = "Veli Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 5,
                            FlyCode = "CCCSDDF11223232",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(788),
                            FromAirportId = 1,
                            Name = "Cavad Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 6,
                            FlyCode = "MMCSDDF11223232",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(789),
                            FromAirportId = 1,
                            Name = "Mahmud Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 7,
                            FlyCode = "MMCSFFDDF11223232",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(791),
                            FromAirportId = 1,
                            Name = "Mahmud Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 8,
                            FlyCode = "MMCSDSSDF11223232",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(792),
                            FromAirportId = 1,
                            Name = "Mahmud Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 9,
                            FlyCode = "MMCSDDFDD11223232",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(794),
                            FromAirportId = 1,
                            Name = "Vasif Salahov",
                            ToAirportId = 2
                        },
                        new
                        {
                            Id = 10,
                            FlyCode = "MMCSDDF11223232SS",
                            FlyDate = new DateTime(2022, 8, 8, 4, 55, 54, 936, DateTimeKind.Local).AddTicks(795),
                            FromAirportId = 3,
                            Name = "Vidadi Salahov",
                            ToAirportId = 2
                        });
                });

            modelBuilder.Entity("BaggageTracking.Models.Baggage", b =>
                {
                    b.HasOne("BaggageTracking.Models.Ticket", "Ticket")
                        .WithOne("Baggage")
                        .HasForeignKey("BaggageTracking.Models.Baggage", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaggageTracking.Models.Status", "IsOut")
                        .WithMany("IsOuts")
                        .HasForeignKey("IsOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaggageTracking.Models.Status", "Landed")
                        .WithMany("Landeds")
                        .HasForeignKey("LandedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaggageTracking.Models.Status", "Loading")
                        .WithMany("Loadings")
                        .HasForeignKey("LoadingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaggageTracking.Models.Platform", "OutPlatform")
                        .WithMany("OutBaggages")
                        .HasForeignKey("OutPlatformId");

                    b.Navigation("IsOut");

                    b.Navigation("Landed");

                    b.Navigation("Loading");

                    b.Navigation("OutPlatform");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("BaggageTracking.Models.Platform", b =>
                {
                    b.HasOne("BaggageTracking.Models.Airport", "Airport")
                        .WithMany("Platforms")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airport");
                });

            modelBuilder.Entity("BaggageTracking.Models.Ticket", b =>
                {
                    b.HasOne("BaggageTracking.Models.Airport", "FromAirport")
                        .WithMany("FromAirports")
                        .HasForeignKey("FromAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaggageTracking.Models.Airport", "ToAirport")
                        .WithMany("ToAirports")
                        .HasForeignKey("ToAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromAirport");

                    b.Navigation("ToAirport");
                });

            modelBuilder.Entity("BaggageTracking.Models.Airport", b =>
                {
                    b.Navigation("FromAirports");

                    b.Navigation("Platforms");

                    b.Navigation("ToAirports");
                });

            modelBuilder.Entity("BaggageTracking.Models.Platform", b =>
                {
                    b.Navigation("OutBaggages");
                });

            modelBuilder.Entity("BaggageTracking.Models.Status", b =>
                {
                    b.Navigation("IsOuts");

                    b.Navigation("Landeds");

                    b.Navigation("Loadings");
                });

            modelBuilder.Entity("BaggageTracking.Models.Ticket", b =>
                {
                    b.Navigation("Baggage")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
