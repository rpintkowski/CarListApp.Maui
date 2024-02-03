using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarListApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class UserAndAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42358d3e-3c22-45e1-be81-6caa7ba865ef", null, "User", "USER" },
                    { "d1b5952a-2162-46c7-b29e-1a2a68922c14", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f4631bd-f907-4409-b416-ba356312e659", 0, "1e2968ee-5c83-4168-b9d8-b9a5862324ee", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGAGGF0WC9mGv4MQsJttUV93CjR4jBJqLcDHY6fQquLxux7K+EqFhNXLeQ9VXp5Uzw==", null, false, "6f39b67a-8485-47d0-99ae-09fe4a8a3ff9", false, "user@localhost.com" },
                    { "408aa945-3d84-4421-8342-7269ec64d949", 0, "e5226cec-3b3b-4fb3-865f-6eb25feb344c", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENcFPRIJTj5b/O4moORSNK0fIgLjO2lsDUmyz61X9dy4YFApkkR5brYv2swiy8RUuw==", null, false, "b217329b-fb5e-4465-9f81-c2a98f6b210d", false, "admin@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Honda", "Fit", "ABC" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Honda", "Civic", "ABC2" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Honda", "Stream", "ABC1" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Nissan", "Note", "ABC4" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Nissan", "Atlas", "ABC5" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Nissan", "Dualis", "ABC6" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[,]
                {
                    { 7, "Nissan", "Murano", "ABC7" },
                    { 8, "Audi", "A5", "ABC8" },
                    { 9, "BMW", "M3", "ABC9" },
                    { 10, "Jaguar", "F-Pace", "ABC10" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "42358d3e-3c22-45e1-be81-6caa7ba865ef", "3f4631bd-f907-4409-b416-ba356312e659" },
                    { "d1b5952a-2162-46c7-b29e-1a2a68922c14", "408aa945-3d84-4421-8342-7269ec64d949" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42358d3e-3c22-45e1-be81-6caa7ba865ef", "3f4631bd-f907-4409-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1b5952a-2162-46c7-b29e-1a2a68922c14", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Tundra", "Toyota", "123456" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Versa", "Nissan", "123456" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Civic", "Honda", "123456" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "X1", "BMW", "123456" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "C250", "Mercedes", "123456" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Make", "Model", "Vin" },
                values: new object[] { "Fiesta", "Ford", "123456" });
        }
    }
}
