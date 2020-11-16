using Microsoft.EntityFrameworkCore.Migrations;

namespace Dim_Dat_Pro_2._0.Migrations.CMPG323_Project2_dataset
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMPG323 project 2 dataset",
                columns: table => new
                {
                    EmployeeNumber = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Age = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Attrition = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    BusinessTravel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DailyRate = table.Column<decimal>(type: "money", nullable: true),
                    Department = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DistanceFromHome = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Education = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    EducationField = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeCount = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    EnvironmentSatisfaction = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    HourlyRate = table.Column<decimal>(type: "money", nullable: true),
                    JobInvolvement = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JobLevel = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    JobRole = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    JobSatisfaction = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MonthlyIncome = table.Column<decimal>(type: "money", nullable: true),
                    MonthlyRate = table.Column<decimal>(type: "money", nullable: true),
                    NumCompaniesWorked = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Over18 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    OverTime = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PercentSalaryHike = table.Column<decimal>(type: "decimal(28,0)", nullable: true),
                    PerformanceRating = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RelationshipSatisfaction = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    StandardHours = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    StockOptionLevel = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    TotalWorkingYears = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    TrainingTimesLastYear = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    WorkLifeBalance = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    YearsAtCompany = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    YearsInCurrentRole = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    YearsSinceLastPromotion = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    YearsWithCurrManager = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMPG323 project 2 dataset", x => x.EmployeeNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMPG323 project 2 dataset");
        }
    }
}
