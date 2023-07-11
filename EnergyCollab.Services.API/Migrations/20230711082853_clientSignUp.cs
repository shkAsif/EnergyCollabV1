using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyCollab.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class clientSignUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ClientSignups",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ClientSignups");
        }
    }
}
