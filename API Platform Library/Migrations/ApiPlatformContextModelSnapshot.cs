﻿// <auto-generated />
using API_Platform_Library.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Platform_Library.Migrations
{
    [DbContext(typeof(ApiPlatformContext))]
    partial class ApiPlatformContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_Platform_Library.Models.Tarot.Tarot", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Arcana")
                        .HasColumnType("int");

                    b.Property<int>("Astrology")
                        .HasColumnType("int");

                    b.Property<string>("BiddyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiddyMeaningInv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiddyMeaningUp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Court")
                        .HasColumnType("bit");

                    b.Property<string>("EkelenDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EkelenMeaningInv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EkelenMeaningUp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EkelenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Element")
                        .HasColumnType("int");

                    b.Property<string>("HermeticDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HermeticMeaningInv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HermeticMeaningUp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HermeticTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RWImage")
                        .HasColumnType("int");

                    b.Property<int>("Sephirot")
                        .HasColumnType("int");

                    b.Property<int>("Suit")
                        .HasColumnType("int");

                    b.Property<int>("Tetragrammaton")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Tarot");
                });
#pragma warning restore 612, 618
        }
    }
}
