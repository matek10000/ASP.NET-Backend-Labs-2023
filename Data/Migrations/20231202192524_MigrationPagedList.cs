using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationPagedList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4eb63cbf-e676-454e-9725-35d238afac6f", "36997a8a-87df-4e4b-b17f-df24d1e84f82" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb63cbf-e676-454e-9725-35d238afac6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36997a8a-87df-4e4b-b17f-df24d1e84f82");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4eb63cbf-e676-454e-9725-35d238afac6f", "4eb63cbf-e676-454e-9725-35d238afac6f", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "36997a8a-87df-4e4b-b17f-df24d1e84f82", 0, "f58eb8c0-9711-4c92-8a69-21b67fd6acfc", "mateusz.dybas@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEGTXdrH19nO4HSWUDM47qBbs0kJAlGUXUNpMJaGHK8EQCV0mI1oPRPTfyh1zuuGpKw==", null, false, "fb5ac7d7-1ef2-4bdb-8094-e3b699ce2889", false, "mateusz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4eb63cbf-e676-454e-9725-35d238afac6f", "36997a8a-87df-4e4b-b17f-df24d1e84f82" });
        }
    }
}
