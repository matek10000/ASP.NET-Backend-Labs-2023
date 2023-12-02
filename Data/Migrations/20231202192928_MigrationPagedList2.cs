using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationPagedList2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1f17228-d490-443a-892a-317b143c123a", "384367ca-2cdb-4be7-a4fe-84e3a993277e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1f17228-d490-443a-892a-317b143c123a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384367ca-2cdb-4be7-a4fe-84e3a993277e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c03c78d-65a1-4548-be17-47e1897c0f68", "2c03c78d-65a1-4548-be17-47e1897c0f68", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7cec9b01-af14-4986-9e3a-fcac12bebf72", 0, "d8a40175-1e88-4280-a680-4712560752ed", "mateusz.dybas@gmail.com", true, false, null, "MATEUSZ.DYBAS@GMAIL.COM", "MATEUSZ", "AQAAAAEAACcQAAAAEPeKLayEIf/FojEQNnmmxi9Y8HLoQnq37FPKrdns+2M6WJJ9lNDAGLq3861q2wfTjw==", null, false, "9db83026-49d9-463b-9f95-10eeabf7a897", false, "mateusz" });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "ContactId", "Birth", "Email", "Name", "OrganizationId", "Phone" },
                values: new object[,]
                {
                    { 3, new DateTime(2002, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marek@wsei.edu.pl", "Marek", 1, "123647920" },
                    { 4, new DateTime(2006, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jula@wsei.edu.pl", "Julia", 1, "696942021" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c03c78d-65a1-4548-be17-47e1897c0f68", "7cec9b01-af14-4986-9e3a-fcac12bebf72" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c03c78d-65a1-4548-be17-47e1897c0f68", "7cec9b01-af14-4986-9e3a-fcac12bebf72" });

            migrationBuilder.DeleteData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 4);

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
                values: new object[] { "a1f17228-d490-443a-892a-317b143c123a", "a1f17228-d490-443a-892a-317b143c123a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "384367ca-2cdb-4be7-a4fe-84e3a993277e", 0, "cd9dda96-017a-4878-bad3-a5350ac8a026", "mateusz.dybas@gmail.com", true, false, null, "MATEUSZ.DYBAS@GMAIL.COM", "MATEUSZ", "AQAAAAEAACcQAAAAEH/xqZjXSsvYxoUa94lDJwy/FStCD0cJpXnUChPKDBQ1IpZVBSZm08KoQ67qGZ35dA==", null, false, "fa5625ce-dabe-45f6-b76a-1b077fd8a873", false, "mateusz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a1f17228-d490-443a-892a-317b143c123a", "384367ca-2cdb-4be7-a4fe-84e3a993277e" });
        }
    }
}
