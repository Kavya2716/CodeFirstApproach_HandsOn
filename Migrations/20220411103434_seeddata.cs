using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 1L, "In meeting need to discus some points.", true, "Meeting with management" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 2L, "List of the items to buy.", false, "Go for Shopping" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 3L, "Here is task to ask to do on call", true, "Call someone to do some task" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
