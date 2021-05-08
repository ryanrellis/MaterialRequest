using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaterialRequest.Migrations
{
    public partial class InitiateDbAndAddRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeNeeded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
