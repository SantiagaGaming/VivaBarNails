using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaBarNails.Data.Migrations
{
    public partial class ClientDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NailMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NailMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NailMasterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_NailMasters_NailMasterId",
                        column: x => x.NailMasterId,
                        principalTable: "NailMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NailOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NailName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NailClientId = table.Column<int>(type: "int", nullable: true),
                    MasterId = table.Column<int>(type: "int", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NailOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NailOrders_Clients_NailClientId",
                        column: x => x.NailClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NailOrders_NailMasters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "NailMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_NailMasterId",
                table: "Clients",
                column: "NailMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_NailOrders_MasterId",
                table: "NailOrders",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_NailOrders_NailClientId",
                table: "NailOrders",
                column: "NailClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NailOrders");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "NailMasters");
        }
    }
}
