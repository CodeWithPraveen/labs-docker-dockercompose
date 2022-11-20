﻿// <auto-generated />
using System;
using BrezyWeather.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BrezyWeather.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    [Migration("20221113084809_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BrezyWeather.Models.Weather", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AirQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Humidity")
                        .HasColumnType("real");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Weather");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AirQuality = "Fair",
                            Humidity = 78f,
                            Temperature = 28f,
                            Time = new DateTime(2022, 11, 13, 15, 48, 9, 622, DateTimeKind.Local).AddTicks(6580)
                        },
                        new
                        {
                            ID = 2,
                            AirQuality = "Healthy",
                            Humidity = 84f,
                            Temperature = 27f,
                            Time = new DateTime(2022, 11, 13, 14, 48, 9, 622, DateTimeKind.Local).AddTicks(6610)
                        },
                        new
                        {
                            ID = 3,
                            AirQuality = "Healthy",
                            Humidity = 40f,
                            Temperature = 33f,
                            Time = new DateTime(2022, 11, 13, 13, 48, 9, 622, DateTimeKind.Local).AddTicks(6610)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}