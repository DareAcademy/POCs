﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POCs.data;

#nullable disable

namespace POCs.Migrations
{
    [DbContext(typeof(pocContext))]
    [Migration("20230212080348_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("POCs.data.Course_days", b =>
                {
                    b.Property<int>("Section_Id")
                        .HasColumnType("int");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.HasKey("Section_Id", "day");

                    b.ToTable("course_days");
                });

            modelBuilder.Entity("POCs.data.Course_Sections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("course_Sections");
                });

            modelBuilder.Entity("POCs.data.Course_days", b =>
                {
                    b.HasOne("POCs.data.Course_Sections", "sections")
                        .WithMany("lidays")
                        .HasForeignKey("Section_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sections");
                });

            modelBuilder.Entity("POCs.data.Course_Sections", b =>
                {
                    b.Navigation("lidays");
                });
#pragma warning restore 612, 618
        }
    }
}
