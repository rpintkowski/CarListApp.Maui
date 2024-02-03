using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class Serilog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e2968ee-5c83-4168-b9d8-b9a5862324ee", "AQAAAAIAAYagAAAAEGAGGF0WC9mGv4MQsJttUV93CjR4jBJqLcDHY6fQquLxux7K+EqFhNXLeQ9VXp5Uzw==", "6f39b67a-8485-47d0-99ae-09fe4a8a3ff9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5226cec-3b3b-4fb3-865f-6eb25feb344c", "AQAAAAIAAYagAAAAENcFPRIJTj5b/O4moORSNK0fIgLjO2lsDUmyz61X9dy4YFApkkR5brYv2swiy8RUuw==", "b217329b-fb5e-4465-9f81-c2a98f6b210d" });
        }
    }
}
