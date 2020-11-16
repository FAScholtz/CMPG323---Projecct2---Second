﻿// <auto-generated />
using System;
using Dim_Dat_Pro_2._0.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dim_Dat_Pro_2._0.Migrations.CMPG323_Project2_dataset
{
    [DbContext(typeof(CMPG323_Project2_datasetContext))]
    [Migration("20201116075425_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dim_Dat_Pro_2._0.Models.Entities.Cmpg323Project2Dataset", b =>
                {
                    b.Property<decimal>("EmployeeNumber")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("Age")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("Attrition")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("BusinessTravel")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal?>("DailyRate")
                        .HasColumnType("money");

                    b.Property<string>("Department")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("DistanceFromHome")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("Education")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("EducationField")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal?>("EmployeeCount")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("EnvironmentSatisfaction")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("HourlyRate")
                        .HasColumnType("money");

                    b.Property<decimal?>("JobInvolvement")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("JobLevel")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("JobRole")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("JobSatisfaction")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("MaritalStatus")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("MonthlyIncome")
                        .HasColumnType("money");

                    b.Property<decimal?>("MonthlyRate")
                        .HasColumnType("money");

                    b.Property<decimal?>("NumCompaniesWorked")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("Over18")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("OverTime")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)");

                    b.Property<decimal?>("PercentSalaryHike")
                        .HasColumnType("decimal(28,0)");

                    b.Property<decimal?>("PerformanceRating")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("RelationshipSatisfaction")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("StandardHours")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("StockOptionLevel")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("TotalWorkingYears")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("TrainingTimesLastYear")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("WorkLifeBalance")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("YearsAtCompany")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("YearsInCurrentRole")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("YearsSinceLastPromotion")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal?>("YearsWithCurrManager")
                        .HasColumnType("numeric(18,0)");

                    b.HasKey("EmployeeNumber");

                    b.ToTable("CMPG323 project 2 dataset");
                });
#pragma warning restore 612, 618
        }
    }
}
