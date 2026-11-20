using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UniqueConstraintForPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8f45639-9ff7-4b97-bb05-bae6af354365", "AQAAAAIAAYagAAAAEL3cw7EifphqBZQ9ifvU8JL0b7Xc91/+H/yttW40VloqdQ5BI1ATQzY4XH6ko8HqcQ==", "9171ca1c-e026-46c6-9ff2-e0023c0aa0dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84e8127f-a2d7-41fc-8623-026f3f4bc23a", "AQAAAAIAAYagAAAAEHUrnP+7Usvfsu8irhVt9llka9iuSBHuP6iwuEuz+PG2x4hnV6+W2CStpF15px5YBA==", "b3cf32c3-dc3f-49e6-bd5c-a1c7fc3b7ef7" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b584865-d210-45f0-a2e2-4a58bf359b22", "AQAAAAIAAYagAAAAEA2C5eOBnuFVI4qD+8YUfCN23TSBIrsV51JGEk6H0UXtpBfTaVGUupHXLa93osiyhQ==", "f3f41bae-a348-4b73-9971-f79bd4f8e3d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05fabf5e-c132-4b48-989c-ea27ba87b63b", "AQAAAAIAAYagAAAAECQz0Vk8tzth7guu41tLzSmPfjWf6LQC+Ck6qQcsDuzsv85VrZ75PoDwpui3b+1XbA==", "1930cea1-1aba-4bd5-b0e3-11b6d07b1f75" });
        }
    }
}
