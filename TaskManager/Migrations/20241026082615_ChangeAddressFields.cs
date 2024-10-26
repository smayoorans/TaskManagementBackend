using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAddressFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdddressLine2",
                table: "Address",
                newName: "AddressLine2");

            migrationBuilder.RenameColumn(
                name: "AdddressLine1",
                table: "Address",
                newName: "AddressLine1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine2",
                table: "Address",
                newName: "AdddressLine2");

            migrationBuilder.RenameColumn(
                name: "AddressLine1",
                table: "Address",
                newName: "AdddressLine1");
        }
    }
}
