using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSaver.Domain.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Card", "Cash", "FullName", "Gmail", "UserImage" },
                values: new object[] { new Guid("6e33fa08-bc0f-438c-a21b-bcf4fc227661"), 0.0, 0.0, "Test Testington", "test@gmail.com", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e33fa08-bc0f-438c-a21b-bcf4fc227661"));
        }
    }
}
