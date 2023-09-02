using Microsoft.EntityFrameworkCore.Migrations;

namespace TopLearn.DataLeyer.Migrations
{
    public partial class AddChangIsTrueAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTrue",
                table: "Answers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTrue",
                table: "Answers");
        }
    }
}
