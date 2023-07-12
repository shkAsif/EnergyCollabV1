using System;
using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
namespace EnergyCollab.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class addOrgandVacancyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "organizationId",
                table: "Vacancies",
                type: "int",
                nullable: true);
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });
            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_organizationId",
                table: "Vacancies",
                column: "organizationId");
            migrationBuilder.CreateIndex(
                name: "IX_Organizations_countryId",
                table: "Organizations",
                column: "countryId");
            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Organizations_organizationId",
                table: "Vacancies",
                column: "organizationId",
                principalTable: "Organizations",
                principalColumn: "Id");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Organizations_organizationId",
                table: "Vacancies");
            migrationBuilder.DropTable(
                name: "Organizations");
            migrationBuilder.DropIndex(
                name: "IX_Vacancies_organizationId",
                table: "Vacancies");
            migrationBuilder.DropColumn(
                name: "organizationId",
                table: "Vacancies");
        }
    }
}
