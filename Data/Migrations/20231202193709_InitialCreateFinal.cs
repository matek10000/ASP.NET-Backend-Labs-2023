using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c03c78d-65a1-4548-be17-47e1897c0f68", "7cec9b01-af14-4986-9e3a-fcac12bebf72" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c03c78d-65a1-4548-be17-47e1897c0f68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cec9b01-af14-4986-9e3a-fcac12bebf72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81ea5466-a1dc-4440-ae51-d44e01ca7976", "81ea5466-a1dc-4440-ae51-d44e01ca7976", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "325fba42-5a62-42fd-a675-339be123b77f", 0, "a5ed6c82-737c-473f-ab73-b4af17cb1352", "mateusz.dybas@gmail.com", true, false, null, "MATEUSZ.DYBAS@GMAIL.COM", "MATEUSZ", "AQAAAAEAACcQAAAAED38cHQ99q5xknpMV5DmZvBaHLv8SWr9FHDZC0/Q0gFFGpItegilKdldSGazWGDmRA==", null, false, "57832205-67ef-43cd-9414-2da15138340f", false, "mateusz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "81ea5466-a1dc-4440-ae51-d44e01ca7976", "325fba42-5a62-42fd-a675-339be123b77f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81ea5466-a1dc-4440-ae51-d44e01ca7976", "325fba42-5a62-42fd-a675-339be123b77f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ea5466-a1dc-4440-ae51-d44e01ca7976");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325fba42-5a62-42fd-a675-339be123b77f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c03c78d-65a1-4548-be17-47e1897c0f68", "2c03c78d-65a1-4548-be17-47e1897c0f68", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7cec9b01-af14-4986-9e3a-fcac12bebf72", 0, "d8a40175-1e88-4280-a680-4712560752ed", "mateusz.dybas@gmail.com", true, false, null, "MATEUSZ.DYBAS@GMAIL.COM", "MATEUSZ", "AQAAAAEAACcQAAAAEPeKLayEIf/FojEQNnmmxi9Y8HLoQnq37FPKrdns+2M6WJJ9lNDAGLq3861q2wfTjw==", null, false, "9db83026-49d9-463b-9f95-10eeabf7a897", false, "mateusz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c03c78d-65a1-4548-be17-47e1897c0f68", "7cec9b01-af14-4986-9e3a-fcac12bebf72" });
        }
    }
}
