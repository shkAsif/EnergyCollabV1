using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
namespace EnergyCollab.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class renamecolumnabbr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndustryExperience",
                table: "Vacancies");
            //migrationBuilder.AddColumn<int>(
            //    name: "experienceId",
            //    table: "Vacancies",
            //    type: "int",
            //    nullable: true);
            migrationBuilder.RenameColumn(
                name: "Abbrivation",
                table: "Countries",
                newName: "CountryCode");
            //migrationBuilder.CreateTable(
            //    name: "Experiences",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Range = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Experiences", x => x.Id);
            //    });
            //migrationBuilder.CreateIndex(
            //    name: "IX_Vacancies_experienceId",
            //    table: "Vacancies",
            //    column: "experienceId");
            //migrationBuilder.AddForeignKey(
            //    name: "FK_Vacancies_Experiences_experienceId",
            //    table: "Vacancies",
            //    column: "experienceId",
            //    principalTable: "Experiences",
            //    principalColumn: "Id");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Experiences_experienceId",
                table: "Vacancies");
            migrationBuilder.DropTable(
                name: "Experiences");
            migrationBuilder.DropIndex(
                name: "IX_Vacancies_experienceId",
                table: "Vacancies");
            migrationBuilder.DropColumn(
                name: "experienceId",
                table: "Vacancies");
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Countries");
            migrationBuilder.AddColumn<int>(
                name: "IndustryExperience",
                table: "Vacancies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
