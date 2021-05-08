using Microsoft.EntityFrameworkCore.Migrations;

namespace MaterialRequest.Migrations
{
    public partial class AddLocationToRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Requests",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Requests");
        }
    }
}
