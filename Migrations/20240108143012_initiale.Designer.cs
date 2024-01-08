﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelationsNaN.Data;

#nullable disable

namespace RelationsNaN.Migrations
{
    [DbContext(typeof(RelationsNaNContext))]
    [Migration("20240108143012_initiale")]
    partial class initiale
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BundleGame", b =>
                {
                    b.Property<int>("BundlesId")
                        .HasColumnType("int");

                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.HasKey("BundlesId", "GamesId");

                    b.HasIndex("GamesId");

                    b.ToTable("BundleGame");
                });

            modelBuilder.Entity("RelationsNaN.Models.Bundle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bundle");
                });

            modelBuilder.Entity("RelationsNaN.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("RelationsNaN.Models.GamePurchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("GamePurchase");
                });

            modelBuilder.Entity("BundleGame", b =>
                {
                    b.HasOne("RelationsNaN.Models.Bundle", null)
                        .WithMany()
                        .HasForeignKey("BundlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RelationsNaN.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RelationsNaN.Models.GamePurchase", b =>
                {
                    b.HasOne("RelationsNaN.Models.Game", null)
                        .WithMany("GamePurchases")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RelationsNaN.Models.Game", b =>
                {
                    b.Navigation("GamePurchases");
                });
#pragma warning restore 612, 618
        }
    }
}
