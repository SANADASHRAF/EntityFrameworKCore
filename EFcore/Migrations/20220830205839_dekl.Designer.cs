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
    [Migration("20220830205839_dekl")]
    partial class dekl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("attendanceemployee", b =>
                {
                    b.Property<int>("attendancesemployeeid")
                        .HasColumnType("int");

                    b.Property<int>("employeesid")
                        .HasColumnType("int");

                    b.HasKey("attendancesemployeeid", "employeesid");

                    b.HasIndex("employeesid");

                    b.ToTable("attendanceemployee");
                });

            modelBuilder.Entity("EFcore.attendance", b =>
                {
                    b.Property<int>("employeeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeid"), 1L, 1);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("employeeid");

                    b.ToTable("attendance");
                });

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

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("EFcore.project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departmentid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("project");
                });

            modelBuilder.Entity("attendanceemployee", b =>
                {
                    b.HasOne("EFcore.attendance", null)
                        .WithMany()
                        .HasForeignKey("attendancesemployeeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFcore.employee", null)
                        .WithMany()
                        .HasForeignKey("employeesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("EFcore.project", b =>
                {
                    b.HasOne("EFcore.department", "department")
                        .WithMany("projects")
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

                    b.Navigation("projects");
                });
#pragma warning restore 612, 618
        }
    }
}
