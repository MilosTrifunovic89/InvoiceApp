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
    [Migration("20200902180231_AddContactPersonConfiguration")]
    partial class AddContactPersonConfiguration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .IsRequired()
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
#pragma warning restore 612, 618
        }
    }
}
