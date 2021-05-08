using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaterialRequest.Migrations
{
    public partial class AddCompletedAndCompletedAtToRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Requests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedAt",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "CompletedAt",
                table: "Requests");
        }
    }
}
