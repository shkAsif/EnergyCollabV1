using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
namespace EnergyCollab.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class addsignup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "SignUps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
            migrationBuilder.AddColumn<string>(
                name: "LoginUser",
                table: "SignUps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "SignUps");
            migrationBuilder.DropColumn(
                name: "LoginUser",
                table: "SignUps");
        }
    }
}
