using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_n_Bite_API.Migrations
{
    public partial class datafiller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Arrival", "Departure", "Number" },
                values: new object[] { 1, "Madrid", "Brussel", "X44795" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
