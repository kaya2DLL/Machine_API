using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelFinder_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<int>(type: "int", nullable: false),
                    MachineNumber = table.Column<int>(type: "int", nullable: false),
                    InputNumber = table.Column<int>(type: "int", nullable: false),
                    TerminalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCheck = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThreadSleepTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Connections");
        }
    }
}
