// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentLoanSimulator.Models;

namespace StudentLoanSimulator.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentLoanSimulator.Models.Employment", b =>
                {
                    b.Property<int>("EmploymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Emplyeed")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<double>("Wage")
                        .HasColumnType("float");

                    b.Property<int>("WageBreakdown")
                        .HasColumnType("int");

                    b.HasKey("EmploymentId");

                    b.HasIndex("LocationId");

                    b.ToTable("Employment");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Housing", b =>
                {
                    b.Property<int>("HousingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<int>("CostBreakdown")
                        .HasColumnType("int");

                    b.Property<int>("HousingType")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfYears")
                        .HasColumnType("int");

                    b.Property<int>("ResidencyType")
                        .HasColumnType("int");

                    b.Property<int?>("ScenarioId")
                        .HasColumnType("int");

                    b.HasKey("HousingId");

                    b.HasIndex("ScenarioId");

                    b.ToTable("Housing");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Miscelaneous", b =>
                {
                    b.Property<int>("MiscelaneousId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("MiscelaneousId");

                    b.ToTable("Miscelaneous");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Nutrition", b =>
                {
                    b.Property<int>("NutritionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<double>("DaysFedWithinBudget")
                        .HasColumnType("float");

                    b.Property<double>("DaysNotFedWithinBudget")
                        .HasColumnType("float");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("MealsPerDay")
                        .HasColumnType("int");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<double>("TimeSpan")
                        .HasColumnType("float");

                    b.HasKey("NutritionId");

                    b.ToTable("Nutrition");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Scenario", b =>
                {
                    b.Property<int>("ScenarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmploymentId")
                        .HasColumnType("int");

                    b.Property<int?>("MiscelaneousId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NutritionId")
                        .HasColumnType("int");

                    b.HasKey("ScenarioId");

                    b.HasIndex("EmploymentId");

                    b.HasIndex("MiscelaneousId");

                    b.HasIndex("NutritionId");

                    b.ToTable("Scenarios");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.University", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GrantAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Residency")
                        .HasColumnType("int");

                    b.Property<int?>("ScenarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("ScholarshipAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SchoolYearLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SemesterLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("YearlyTuition")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("UniversityId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ScenarioId");

                    b.ToTable("University");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Employment", b =>
                {
                    b.HasOne("StudentLoanSimulator.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Housing", b =>
                {
                    b.HasOne("StudentLoanSimulator.Models.Scenario", null)
                        .WithMany("Housing")
                        .HasForeignKey("ScenarioId");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Scenario", b =>
                {
                    b.HasOne("StudentLoanSimulator.Models.Employment", "Employment")
                        .WithMany()
                        .HasForeignKey("EmploymentId");

                    b.HasOne("StudentLoanSimulator.Models.Miscelaneous", "Miscelaneous")
                        .WithMany()
                        .HasForeignKey("MiscelaneousId");

                    b.HasOne("StudentLoanSimulator.Models.Nutrition", "Nutrition")
                        .WithMany()
                        .HasForeignKey("NutritionId");

                    b.Navigation("Employment");

                    b.Navigation("Miscelaneous");

                    b.Navigation("Nutrition");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.University", b =>
                {
                    b.HasOne("StudentLoanSimulator.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("StudentLoanSimulator.Models.Scenario", null)
                        .WithMany("Universities")
                        .HasForeignKey("ScenarioId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("StudentLoanSimulator.Models.Scenario", b =>
                {
                    b.Navigation("Housing");

                    b.Navigation("Universities");
                });
#pragma warning restore 612, 618
        }
    }
}
