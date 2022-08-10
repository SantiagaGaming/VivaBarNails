using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaBarNails.Data.Migrations
{
    public partial class MastersUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "NailMasters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "NailMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
