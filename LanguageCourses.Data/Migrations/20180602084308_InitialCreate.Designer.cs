﻿// <auto-generated />
using System;
using LanguageCourses.Data.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LanguageCourses.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180602084308_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LanguageCourses.Data.Model.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseLevel");

                    b.Property<string>("FirstNameTeacher");

                    b.Property<string>("Language");

                    b.Property<string>("LastNameTeacher");

                    b.Property<int>("NumberOfSeats");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LanguageCourses.Data.Model.CourseUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CourseId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseUsers");
                });

            modelBuilder.Entity("LanguageCourses.Data.Model.CourseUserMark", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CourseUserId");

                    b.Property<decimal>("Mark");

                    b.HasKey("Id");

                    b.HasIndex("CourseUserId");

                    b.ToTable("CourseUserMarks");
                });

            modelBuilder.Entity("LanguageCourses.Data.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DateOfBirthday");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.Property<byte[]>("Salt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LanguageCourses.Data.Model.CourseUser", b =>
                {
                    b.HasOne("LanguageCourses.Data.Model.Course")
                        .WithMany("CourseUsers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LanguageCourses.Data.Model.User")
                        .WithMany("CourseUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LanguageCourses.Data.Model.CourseUserMark", b =>
                {
                    b.HasOne("LanguageCourses.Data.Model.CourseUser")
                        .WithMany("CourseUsersMarks")
                        .HasForeignKey("CourseUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
