﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    partial class TravelApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TravelApi.Models.Travel", b =>
                {
                    b.Property<int>("TravelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Blerb")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("TravelId");

                    b.ToTable("Travels");

                    b.HasData(
                        new
                        {
                            TravelId = 1,
                            Blerb = "It was pretty cool, sunny but a nice cool sea breeze. food was great",
                            Country = "United States of America",
                            Location = "San Fancisco, CA",
                            Rating = 8
                        },
                        new
                        {
                            TravelId = 2,
                            Blerb = "This town is whack AF. This is also my home town",
                            Country = "United States of America",
                            Location = "Gonzales, CA",
                            Rating = 2
                        },
                        new
                        {
                            TravelId = 3,
                            Blerb = "I feel like I'm in California, with all the driving i have to do to get around. coffee was over rated but the food was pretty ok",
                            Country = "United States of America",
                            Location = "Seattle, WA",
                            Rating = 4
                        },
                        new
                        {
                            TravelId = 4,
                            Blerb = "Christopher Moore said it best, the Monterey Peninsula is best for the Newly Wed and Nearly Dead",
                            Country = "United States of America",
                            Location = "Monterey, CA",
                            Rating = 6
                        },
                        new
                        {
                            TravelId = 5,
                            Blerb = "if an armpit was a city, it would be Bakersfield. nothing of note",
                            Country = "United States of America",
                            Location = "Bakersfield, CA",
                            Rating = 1
                        },
                        new
                        {
                            TravelId = 6,
                            Blerb = "this was dope af. a lot of great culture and history. amazing food",
                            Country = "Mexico",
                            Location = "Mexico City",
                            Rating = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
