using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyCollab.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class removeCompanyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfCompany",
                table: "ClientSignups");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameOfCompany",
                table: "ClientSignups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
