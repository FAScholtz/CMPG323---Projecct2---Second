using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dim_Dat_Pro_2._0.Models.Entities
{
    public partial class CMPG323_Project2_datasetContext : DbContext
    {
        public CMPG323_Project2_datasetContext()
        {
        }

        public CMPG323_Project2_datasetContext(DbContextOptions<CMPG323_Project2_datasetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cmpg323Project2Dataset> Cmpg323Project2Datasets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cmpg323Project2Dataset>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("CMPG323 project 2 dataset");

                entity.Property(e => e.EmployeeNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Attrition)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTravel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRate).HasColumnType("money");

                entity.Property(e => e.Department)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DistanceFromHome).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Education).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EducationField)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EnvironmentSatisfaction).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HourlyRate).HasColumnType("money");

                entity.Property(e => e.JobInvolvement).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JobLevel).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JobRole)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobSatisfaction).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyIncome).HasColumnType("money");

                entity.Property(e => e.MonthlyRate).HasColumnType("money");

                entity.Property(e => e.NumCompaniesWorked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Over18)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OverTime)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PercentSalaryHike).HasColumnType("decimal(28, 0)");

                entity.Property(e => e.PerformanceRating).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RelationshipSatisfaction).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StandardHours).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StockOptionLevel).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotalWorkingYears).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TrainingTimesLastYear).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.WorkLifeBalance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.YearsAtCompany).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.YearsInCurrentRole).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.YearsSinceLastPromotion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.YearsWithCurrManager).HasColumnType("numeric(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
