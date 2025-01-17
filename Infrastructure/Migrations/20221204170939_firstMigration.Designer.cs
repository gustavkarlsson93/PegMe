﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ClubDbContext))]
    [Migration("20221204170939_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("PegMe.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("PegMe.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClubId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LengthIn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LengthOut")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LengthTotal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PegMe.Models.Hole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Par")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Holes");
                });

            modelBuilder.Entity("PegMe.Models.HoleLength", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tee")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HoleId");

                    b.ToTable("HoleLengths");
                });

            modelBuilder.Entity("PegMe.Models.Course", b =>
                {
                    b.HasOne("PegMe.Models.Club", null)
                        .WithMany("Courses")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PegMe.Models.Hole", b =>
                {
                    b.HasOne("PegMe.Models.Course", null)
                        .WithMany("Holes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PegMe.Models.HoleLength", b =>
                {
                    b.HasOne("PegMe.Models.Hole", null)
                        .WithMany("Lengths")
                        .HasForeignKey("HoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PegMe.Models.Club", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("PegMe.Models.Course", b =>
                {
                    b.Navigation("Holes");
                });

            modelBuilder.Entity("PegMe.Models.Hole", b =>
                {
                    b.Navigation("Lengths");
                });
#pragma warning restore 612, 618
        }
    }
}
