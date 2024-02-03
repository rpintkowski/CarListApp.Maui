using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class DurationTimeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b145ee0-53a5-4b3d-8b8e-85045e67d74a", "AQAAAAIAAYagAAAAEJ2n0CTbdfrAjirLtpFbrG88ueCHmjcrNaIKHKTFJEl4eIgcmw/DDrG8toT4BdMx/g==", "e7f714bb-d0f6-49fc-b74f-84520c166e6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d6a5cbd-d341-41c6-b689-bad8278763ea", "AQAAAAIAAYagAAAAEGAdQRWhmuf0rBzYOQk/8LdlT5joLCP5ytNVL8Hd6QjiU7NPQT6kdjCUh+N1HXn43w==", "4f90b4db-2718-4883-9d4f-1df94a882c19" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d002442d-7f9b-453f-b5c6-1663784507fc", "AQAAAAIAAYagAAAAEJ+oOobBhNAwRqyEnYBUUUoAhMjHKnj4yJmAL4HTUjxvuzX1g30CAIlenYMOhxqeUA==", "89b51267-db56-4176-85b4-37715b0c91f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ada1fdb-1ca3-4e77-868d-82611458f54b", "AQAAAAIAAYagAAAAEFkVsYYZKrnTr1bGr8RbkvsT/xwuKmS1kj8xqyeq72kfNolSuTSRyfOKFDb/rJP3UA==", "0c7e2bb5-945d-406d-9c0d-66c0cf38432f" });
        }
    }
}
