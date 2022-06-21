using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoanSimulator.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Miscelaneous",
                columns: table => new
                {
                    MiscelaneousId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miscelaneous", x => x.MiscelaneousId);
                });

            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    NutritionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealsPerDay = table.Column<int>(type: "int", nullable: false),
                    Budget = table.Column<double>(type: "float", nullable: false),
                    DaysFedWithinBudget = table.Column<double>(type: "float", nullable: false),
                    DaysNotFedWithinBudget = table.Column<double>(type: "float", nullable: false),
                    TimeSpan = table.Column<double>(type: "float", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.NutritionId);
                });

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    EmploymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emplyeed = table.Column<bool>(type: "bit", nullable: false),
                    Wage = table.Column<double>(type: "float", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    WageBreakdown = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.EmploymentId);
                    table.ForeignKey(
                        name: "FK_Employment_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scenarios",
                columns: table => new
                {
                    ScenarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentId = table.Column<int>(type: "int", nullable: true),
                    NutritionId = table.Column<int>(type: "int", nullable: true),
                    MiscelaneousId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.ScenarioId);
                    table.ForeignKey(
                        name: "FK_Scenarios_Employment_EmploymentId",
                        column: x => x.EmploymentId,
                        principalTable: "Employment",
                        principalColumn: "EmploymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scenarios_Miscelaneous_MiscelaneousId",
                        column: x => x.MiscelaneousId,
                        principalTable: "Miscelaneous",
                        principalColumn: "MiscelaneousId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scenarios_Nutrition_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Housing",
                columns: table => new
                {
                    HousingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfYears = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    CostBreakdown = table.Column<int>(type: "int", nullable: false),
                    HousingType = table.Column<int>(type: "int", nullable: false),
                    ResidencyType = table.Column<int>(type: "int", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housing", x => x.HousingId);
                    table.ForeignKey(
                        name: "FK_Housing_Scenarios_ScenarioId",
                        column: x => x.ScenarioId,
                        principalTable: "Scenarios",
                        principalColumn: "ScenarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    UniversityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    Residency = table.Column<int>(type: "int", nullable: false),
                    YearlyTuition = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ScholarshipAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrantAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SchoolYearLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SemesterLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.UniversityId);
                    table.ForeignKey(
                        name: "FK_University_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_University_Scenarios_ScenarioId",
                        column: x => x.ScenarioId,
                        principalTable: "Scenarios",
                        principalColumn: "ScenarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employment_LocationId",
                table: "Employment",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Housing_ScenarioId",
                table: "Housing",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Scenarios_EmploymentId",
                table: "Scenarios",
                column: "EmploymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Scenarios_MiscelaneousId",
                table: "Scenarios",
                column: "MiscelaneousId");

            migrationBuilder.CreateIndex(
                name: "IX_Scenarios_NutritionId",
                table: "Scenarios",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_University_LocationId",
                table: "University",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_University_ScenarioId",
                table: "University",
                column: "ScenarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Housing");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "Scenarios");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "Miscelaneous");

            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
