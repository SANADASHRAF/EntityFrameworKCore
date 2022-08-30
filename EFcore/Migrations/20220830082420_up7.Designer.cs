﻿// <auto-generated />
using System;
using EFcore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFcore.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20220830082420_up7")]
    partial class up7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFcore.branch", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("branches");
                });

            modelBuilder.Entity("EFcore.department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("branchid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("branchid");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("EFcore.employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("departmenid")
                        .HasColumnType("int")
                        .HasColumnName("Departmenid");

                    b.Property<int?>("departmentid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("EFcore.maneger", b =>
                {
                    b.Property<int>("manegerid")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("manegerid", "date");

                    b.ToTable("maneger", (string)null);
                });

            modelBuilder.Entity("EFcore.department", b =>
                {
                    b.HasOne("EFcore.branch", "branch")
                        .WithMany("department")
                        .HasForeignKey("branchid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("branch");
                });

            modelBuilder.Entity("EFcore.employee", b =>
                {
                    b.HasOne("EFcore.department", "department")
                        .WithMany("employees")
                        .HasForeignKey("departmentid");

                    b.Navigation("department");
                });

            modelBuilder.Entity("EFcore.branch", b =>
                {
                    b.Navigation("department");
                });

            modelBuilder.Entity("EFcore.department", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
