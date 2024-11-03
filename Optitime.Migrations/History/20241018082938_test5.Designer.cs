﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Optitime.Classes;

#nullable disable

namespace Optitime.Migrations.History
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241018082938_test5")]
    partial class test5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Optitime.Classes.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("CompanyId");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("Optitime.Classes.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentName")
                        .IsUnique();

                    b.ToTable("departments");
                });

            modelBuilder.Entity("Optitime.Classes.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ProjectId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ProjectName")
                        .IsUnique();

                    b.ToTable("projects");
                });

            modelBuilder.Entity("Optitime.Classes.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("RoleId");

                    b.HasIndex("RoleName")
                        .IsUnique();

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Optitime.Classes.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TaskId"));

                    b.Property<int>("AssignedToUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("TaskId");

                    b.HasIndex("AssignedToUserId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskName")
                        .IsUnique();

                    b.ToTable("tasks");
                });

            modelBuilder.Entity("Optitime.Classes.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeamId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("TeamId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("TeamName")
                        .IsUnique();

                    b.ToTable("teams");
                });

            modelBuilder.Entity("Optitime.Classes.TeamMembership", b =>
                {
                    b.Property<int>("TeamMembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeamMembershipId"));

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("TeamMembershipId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("teammemberships");
                });

            modelBuilder.Entity("Optitime.Classes.TimeEntry", b =>
                {
                    b.Property<int>("TimeEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TimeEntryId"));

                    b.Property<double>("Duration")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TaskId")
                        .HasColumnType("integer");

                    b.Property<int?>("TeamId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("TimeEntryId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("timeentries");
                });

            modelBuilder.Entity("Optitime.Classes.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int?>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("TeamId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Optitime.Classes.Department", b =>
                {
                    b.HasOne("Optitime.Classes.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Optitime.Classes.Project", b =>
                {
                    b.HasOne("Optitime.Classes.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Optitime.Classes.Task", b =>
                {
                    b.HasOne("Optitime.Classes.User", "AssignedToUser")
                        .WithMany()
                        .HasForeignKey("AssignedToUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Optitime.Classes.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.Navigation("AssignedToUser");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Optitime.Classes.Team", b =>
                {
                    b.HasOne("Optitime.Classes.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Optitime.Classes.TeamMembership", b =>
                {
                    b.HasOne("Optitime.Classes.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Optitime.Classes.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Optitime.Classes.TimeEntry", b =>
                {
                    b.HasOne("Optitime.Classes.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("Optitime.Classes.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Optitime.Classes.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("Optitime.Classes.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Project");

                    b.Navigation("Task");

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Optitime.Classes.User", b =>
                {
                    b.HasOne("Optitime.Classes.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("Optitime.Classes.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Optitime.Classes.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Optitime.Classes.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Company");

                    b.Navigation("Department");

                    b.Navigation("Role");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
