using Domain.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domain
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {

        }

        public DbSet<Territory> Territories { get; set; }
        public DbSet<PreschoolInstitution> PreschoolInstitutions { get; set; }
        public DbSet<PreschoolInstitutionContactPerson> PreschoolInstitutionContactPeople { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<CourseRealization> CourseRealizations { get; set; }
        public DbSet<CourseRealizationTrainer> CourseRealizationTrainers { get; set; }
        public DbSet<Wage> Wages { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TerritoryConfiguration());
            modelBuilder.ApplyConfiguration(new PreschoolInstitutionConfiguration());
            modelBuilder.ApplyConfiguration(new PreschoolInstitutionContactPersonConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new TrainerConfiguration());
            modelBuilder.ApplyConfiguration(new CourseRealizationConfiguration());
            modelBuilder.ApplyConfiguration(new CourseRealizationTrainerConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceItemConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
