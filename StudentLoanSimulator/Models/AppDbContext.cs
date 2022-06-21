using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentLoanSimulator.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Scenario> Scenarios { get; set; }

        // Additional models would be set like the above

        // OnModelCreating will create data in DB if there is no data. Code will run when we do a new migration in package manager console
        // by calling "add-migration SeedDataAdded"
        // update-database will insert the data into the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO add more seed data later
            // seed three scenarios with full data
            #region Scenario 1
            modelBuilder.Entity<Scenario>().HasData(new Scenario 
            {
                ScenarioId = 1,
                Name = "Mizzou Comp Sci",
                Universities = new List<University>
                {
                    new University 
                    { 
                        UniversityId = 1,
                        Name = "University of Missouri",
                        Location = new Location
                        {
                            LocationId = 1,
                            City = "Columbia",
                            State = "MO",
                            ZipCode = 65201
                        },
                        Residency = Residency.InState,
                        YearlyTuition = 12000,
                        ScholarshipAmount = 0,
                        GrantAmount = 4000,
                        SchoolYearLength = 8,
                        SemesterLength = 4
                    }
                },
                Housing = new List<Housing>
                {
                    new Housing 
                    {
                        HousingId = 1,
                        NumberOfYears = 1,
                        Cost = 7000,
                        CostBreakdown = CostBreakdown.Year,
                        HousingType = HousingType.OnCampus,
                        ResidencyType = ResidencyType.InState
                    },
                    new Housing 
                    {
                        HousingId = 2,
                        NumberOfYears = 3,
                        Cost = 400,
                        CostBreakdown = CostBreakdown.Month,
                        HousingType = HousingType.OffCampus,
                        ResidencyType = ResidencyType.InState
                    }
                },
                EmploymentScenarios = new EmploymentScenarios
                {
                    EmploymentId = 1,
                    Employment = new List<Employment>
                    {
                        new Employment
                        {
                            //EmploymentId = 1,
                            Emplyeed = false
                        }
                    }
                },
                Nutrition = new Nutrition
                {

                },
                Miscelaneous = new Miscelaneous
                {

                }
            });
            #endregion Scenario 1

            #region Scenario 2
            modelBuilder.Entity<Scenario>().HasData(new Scenario
            {
                ScenarioId = 2,
                Name = "Mizzou-Park Comp Sci",
                Universities = new List<University>
                {
                    new University
                    {
                        UniversityId = 1,
                        Name = "University of Missouri",
                        Location = new Location
                        {
                            LocationId = 1,
                            City = "Columbia",
                            State = "MO",
                            ZipCode = 65201
                        },
                        Residency = Residency.InState,
                        YearlyTuition = 12000,
                        ScholarshipAmount = 2000,
                        GrantAmount = 6000,
                        SchoolYearLength = 8,
                        SemesterLength = 4
                    },
                    new University { }
                },
                Housing = new List<Housing>
                {
                    new Housing
                    {
                        HousingId = 1,
                        NumberOfYears = 1,
                        Cost = 7000,
                        CostBreakdown = CostBreakdown.Year,
                        HousingType = HousingType.OnCampus,
                        ResidencyType = ResidencyType.InState
                    },
                    new Housing
                    {
                        HousingId = 2,
                        NumberOfYears = 1,
                        Cost = 400,
                        CostBreakdown = CostBreakdown.Month,
                        HousingType = HousingType.OffCampus,
                        ResidencyType = ResidencyType.InState
                    },
                    new Housing
                    {
                        HousingId = 3,
                        NumberOfYears = 2,
                        Cost = 0,
                        CostBreakdown = CostBreakdown.Month,
                        HousingType = HousingType.AtHome,
                        ResidencyType = ResidencyType.InState
                    }
                },
                EmploymentScenarios = new EmploymentScenarios
                {
                    EmploymentId = 2,
                    Employment = new List<Employment>
                    {
                        new Employment
                        {
                            //EmploymentId = 3,
                            Emplyeed = true,
                            Wage = 15,
                            WageBreakdown = WageBreakdown.Hourly,
                            Location = new Location
                            {
                                LocationId = 1,
                                City = "Mission",
                                State = "KS",
                                ZipCode = 66202
                            }
                        },
                        new Employment
                        {
                            //EmploymentId = 4,
                            Emplyeed = true,
                            Wage = 50000,
                            WageBreakdown = WageBreakdown.Salary,
                            Location = new Location
                            {
                                LocationId = 2,
                                City = "Mission",
                                State = "KS",
                                ZipCode = 66202
                            }
                        }
                    }
                },
                Nutrition = new Nutrition
                {

                },
                Miscelaneous = new Miscelaneous
                {

                }
            });
            #endregion Scenario 2

            #region Scenario 3
            modelBuilder.Entity<Scenario>().HasData(new Scenario
            {
                ScenarioId = 3,
                Name = "Mizzou-UMKC Comp Sci",
                Universities = new List<University>
                {
                    new University
                    {
                        UniversityId = 1,
                        Name = "University of Missouri",
                        Location = new Location
                        {
                            LocationId = 1,
                            City = "Columbia",
                            State = "MO",
                            ZipCode = 65201
                        },
                        Residency = Residency.InState,
                        YearlyTuition = 12000,
                        ScholarshipAmount = 1000,
                        GrantAmount = 0,
                        SchoolYearLength = 8,
                        SemesterLength = 4
                    },
                    new University { }
                },
                Housing = new List<Housing>
                {
                    new Housing
                    {
                        HousingId = 1,
                        NumberOfYears = 1,
                        Cost = 7000,
                        CostBreakdown = CostBreakdown.Year,
                        HousingType = HousingType.OnCampus,
                        ResidencyType = ResidencyType.InState
                    },
                    new Housing
                    {
                        HousingId = 2,
                        NumberOfYears = 3,
                        Cost = 0,
                        CostBreakdown = CostBreakdown.Month,
                        HousingType = HousingType.AtHome,
                        ResidencyType = ResidencyType.InState
                    }
                },
                EmploymentScenarios = new EmploymentScenarios
                {
                    EmploymentId = 3,
                    Employment = new List<Employment>
                    {
                        new Employment
                        {
                            //EmploymentId = 5,
                            Emplyeed = true,
                            Wage = 15,
                            WageBreakdown = WageBreakdown.Hourly,
                            Location = new Location
                            {
                                LocationId = 1,
                                City = "Mission",
                                State = "KS",
                                ZipCode = 66202
                            }
                        }
                    }
                },
                Nutrition = new Nutrition
                {

                },
                Miscelaneous = new Miscelaneous
                {

                }
            });
            #endregion Scenario 3
        }
    }
}
