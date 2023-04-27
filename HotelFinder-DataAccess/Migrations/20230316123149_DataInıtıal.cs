using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelFinder_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataInıtıal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CylcleTime",
                table: "Machines");

            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    OID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineID = table.Column<int>(type: "int", nullable: false),
                    DataExplainID = table.Column<int>(type: "int", nullable: false),
                    DataValue = table.Column<float>(type: "real", nullable: false),
                    Times = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDifferenceValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.OID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.AddColumn<int>(
                name: "CylcleTime",
                table: "Machines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
