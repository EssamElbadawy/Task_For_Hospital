using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Web.Migrations
{
    public partial class AddWorkingAdditionaDayes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkingDays",
                value: "Monday,Wednesday,Tuesday,Thursday,Saturday,Sunday,Friday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "WorkingDays",
                value: "Monday,Wednesday,Tuesday,Thursday,Saturday,Sunday,Friday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "WorkingDays",
                value: "Monday,Wednesday,Tuesday,Thursday,Saturday,Sunday,Friday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "WorkingDays",
                value: "Monday,Wednesday,Tuesday,Thursday,Saturday,Sunday,Friday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "WorkingDays",
                value: "Monday,Wednesday,Tuesday,Thursday,Saturday,Sunday,Friday");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkingDays",
                value: "Monday,Thursday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "WorkingDays",
                value: "Tuesday,Friday,Monday,Thursday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "WorkingDays",
                value: "Tuesday,Thursday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "WorkingDays",
                value: "Monday,Thursday");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "WorkingDays",
                value: "Monday,Wednesday");
        }
    }
}
