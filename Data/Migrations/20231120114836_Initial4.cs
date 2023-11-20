using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress_Street",
                table: "Organizations",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "Adress_PostalCode",
                table: "Organizations",
                newName: "Address_PostalCode");

            migrationBuilder.RenameColumn(
                name: "Adress_City",
                table: "Organizations",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "contacts",
                newName: "ContactId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Organizations",
                newName: "Adress_Street");

            migrationBuilder.RenameColumn(
                name: "Address_PostalCode",
                table: "Organizations",
                newName: "Adress_PostalCode");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Organizations",
                newName: "Adress_City");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "contacts",
                newName: "id");
        }
    }
}
