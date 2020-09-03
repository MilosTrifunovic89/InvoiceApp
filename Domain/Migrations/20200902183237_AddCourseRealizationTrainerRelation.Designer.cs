﻿// <auto-generated />
using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(InvoiceContext))]
    [Migration("20200902183237_AddCourseRealizationTrainerRelation")]
    partial class AddCourseRealizationTrainerRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeCourseZUOV")
                        .HasMaxLength(10);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("CourseShortedName");

                    b.Property<string>("CursePasswordZUOV")
                        .HasMaxLength(10);

                    b.Property<int>("DaysForInvoice");

                    b.Property<int>("DaysForRealization");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Domain.CourseRealization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompletionDay");

                    b.Property<int>("CourseID");

                    b.Property<int?>("NumberOfParticipants");

                    b.Property<int>("PreschoolInstitutionID");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.Property<string>("ZUOVPassword")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("PreschoolInstitutionID");

                    b.ToTable("CourseRealizations");
                });

            modelBuilder.Entity("Domain.CourseRealizationTrainer", b =>
                {
                    b.Property<int>("TrainerID");

                    b.Property<int>("CourseRealizationID");

                    b.HasKey("TrainerID", "CourseRealizationID");

                    b.HasIndex("CourseRealizationID");

                    b.ToTable("CourseRealizationTrainers");
                });

            modelBuilder.Entity("Domain.PreschoolInstitution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cohort");

                    b.Property<int?>("NumberOfLaptops");

                    b.Property<int?>("NumberOfParticipants");

                    b.Property<int?>("NumberOfProfessionalAssosiates");

                    b.Property<int?>("NumberOfProjectors");

                    b.Property<int?>("NumberOfTeachers");

                    b.Property<int?>("NumerOfInstitutions");

                    b.Property<int?>("PIIDMinistry");

                    b.Property<string>("PIName")
                        .HasMaxLength(100);

                    b.Property<int?>("StartYearImplementation");

                    b.Property<int>("TerritoryId");

                    b.HasKey("Id");

                    b.HasIndex("TerritoryId");

                    b.ToTable("PreschoolInstitutions");
                });

            modelBuilder.Entity("Domain.PreschoolInstitutionContactPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50);

                    b.Property<int>("PreschoolInstitutionId");

                    b.Property<int>("Role");

                    b.HasKey("Id");

                    b.HasIndex("PreschoolInstitutionId");

                    b.ToTable("PreschoolInstitutionContactPeople");
                });

            modelBuilder.Entity("Domain.Territory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("Domain.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasMaxLength(50);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("Bank")
                        .HasMaxLength(50);

                    b.Property<long?>("ContractNumber");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<bool>("Equipment");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50);

                    b.Property<int?>("TerritoryId");

                    b.Property<int?>("TrainerPair");

                    b.Property<long?>("VendorNumber");

                    b.HasKey("Id");

                    b.HasIndex("TerritoryId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("Domain.CourseRealization", b =>
                {
                    b.HasOne("Domain.Course", "Course")
                        .WithMany("CourseRealizations")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.PreschoolInstitution", "PreschoolInstitution")
                        .WithMany("CourseRealizations")
                        .HasForeignKey("PreschoolInstitutionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.CourseRealizationTrainer", b =>
                {
                    b.HasOne("Domain.CourseRealization", "CourseRealization")
                        .WithMany("CourseRealizationTrainers")
                        .HasForeignKey("CourseRealizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Trainer", "Trainer")
                        .WithMany("CourseRealizationTrainers")
                        .HasForeignKey("TrainerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.PreschoolInstitution", b =>
                {
                    b.HasOne("Domain.Territory", "Territory")
                        .WithMany("PreschoolInstitutions")
                        .HasForeignKey("TerritoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.PreschoolInstitutionContactPerson", b =>
                {
                    b.HasOne("Domain.PreschoolInstitution", "PreschoolInstitution")
                        .WithMany("PreschoolInstitutionContactPeople")
                        .HasForeignKey("PreschoolInstitutionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Trainer", b =>
                {
                    b.HasOne("Domain.Territory", "Territory")
                        .WithMany("Trainers")
                        .HasForeignKey("TerritoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
