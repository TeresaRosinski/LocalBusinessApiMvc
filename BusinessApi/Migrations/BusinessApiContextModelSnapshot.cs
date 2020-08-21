﻿// <auto-generated />
using BusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessApi.Migrations
{
    [DbContext(typeof(BusinessApiContext))]
    partial class BusinessApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessApi.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Address = "Rogers Park",
                            Description = "Mexican Restaurant",
                            Name = "El Famous",
                            Type = "Restuarant"
                        },
                        new
                        {
                            BusinessId = 2,
                            Address = "Rogers Park",
                            Description = "Mexican Restaurant",
                            Name = "Rockys Tacos",
                            Type = "Restuarant"
                        },
                        new
                        {
                            BusinessId = 3,
                            Address = "Evanston",
                            Description = "Craft Store",
                            Name = "Paper Source",
                            Type = "Store"
                        },
                        new
                        {
                            BusinessId = 4,
                            Address = "Rogers Park",
                            Description = "Amazing Store",
                            Name = "Target",
                            Type = "Store"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
