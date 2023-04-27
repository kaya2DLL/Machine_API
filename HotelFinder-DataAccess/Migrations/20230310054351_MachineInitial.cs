using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelFinder_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MachineInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Machiness",
                table: "Machiness");

            migrationBuilder.RenameTable(
                name: "Machiness",
                newName: "Machines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machines",
                table: "Machines",
                column: "ConnectionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Machines",
                table: "Machines");

            migrationBuilder.RenameTable(
                name: "Machines",
                newName: "Machiness");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machiness",
                table: "Machiness",
                column: "ConnectionID");
        }
    }
}
