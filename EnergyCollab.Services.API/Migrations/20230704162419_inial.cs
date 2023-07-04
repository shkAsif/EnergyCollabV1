using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyCollab.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class inial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityCodeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WillingToTravel = table.Column<bool>(type: "bit", nullable: true),
                    WillingToRelocateCodeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorisedToWorkCodeValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustryExperienceCodeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentTypeCodeValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationCodeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SummaryOfExperienceCategoryCodeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceDisciplineFirstLevelCodeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastCvUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonalWebSiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectBeingDownManned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfPersonnelAvailable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionOfPersonnelAvailable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateProfiles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateProfiles");
        }
    }
}
