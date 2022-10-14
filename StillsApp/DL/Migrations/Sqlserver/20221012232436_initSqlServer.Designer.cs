﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StillsApp;

#nullable disable

namespace StillsApp.DL.Migrations.SqlServer
{
    [DbContext(typeof(DataContext))]
    [Migration("20221012232436_initSqlServer")]
    partial class initSqlServer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StillsApp.DL.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistilleryId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistilleryId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("StillsApp.DL.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistilleryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistilleryId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("StillsApp.DL.Distillery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Distilleries");
                });

            modelBuilder.Entity("StillsApp.DL.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistilleryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistilleryId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("StillsApp.DL.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("StillsApp.DL.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Base64Encoding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistilleryId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistilleryId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("StillsApp.DL.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BarrelProof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BottleProof")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("PercentBarley")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentCorn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentRye")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentWheat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("StillsApp.DL.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistilleryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistilleryId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("StillsApp.DL.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("StillsApp.DL.Address", b =>
                {
                    b.HasOne("StillsApp.DL.Distillery", null)
                        .WithMany("Addresses")
                        .HasForeignKey("DistilleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StillsApp.DL.Brand", b =>
                {
                    b.HasOne("StillsApp.DL.Distillery", null)
                        .WithMany("Brands")
                        .HasForeignKey("DistilleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StillsApp.DL.Distillery", b =>
                {
                    b.HasOne("StillsApp.DL.Owner", null)
                        .WithMany("Distilleries")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StillsApp.DL.Experience", b =>
                {
                    b.HasOne("StillsApp.DL.Distillery", "Distillery")
                        .WithMany("Experiences")
                        .HasForeignKey("DistilleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distillery");
                });

            modelBuilder.Entity("StillsApp.DL.Photo", b =>
                {
                    b.HasOne("StillsApp.DL.Distillery", null)
                        .WithMany("Photos")
                        .HasForeignKey("DistilleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StillsApp.DL.Recipe", b =>
                {
                    b.HasOne("StillsApp.DL.Brand", null)
                        .WithMany("Recipes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StillsApp.DL.Review", b =>
                {
                    b.HasOne("StillsApp.DL.Distillery", null)
                        .WithMany("Reviews")
                        .HasForeignKey("DistilleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StillsApp.DL.Ticket", b =>
                {
                    b.HasOne("StillsApp.DL.Experience", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StillsApp.DL.Brand", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("StillsApp.DL.Distillery", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Brands");

                    b.Navigation("Experiences");

                    b.Navigation("Photos");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("StillsApp.DL.Experience", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("StillsApp.DL.Owner", b =>
                {
                    b.Navigation("Distilleries");
                });
#pragma warning restore 612, 618
        }
    }
}