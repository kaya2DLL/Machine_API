using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelFinder_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newDATA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Datas",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "DataDifferenceValue",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "Times",
                table: "Datas");

            migrationBuilder.RenameTable(
                name: "Datas",
                newName: "PLCQualityCriterionDatas");

            migrationBuilder.AlterColumn<double>(
                name: "DataValue",
                table: "PLCQualityCriterionDatas",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLCQualityCriterionDatas",
                table: "PLCQualityCriterionDatas",
                column: "OID");

            migrationBuilder.CreateIndex(
                name: "IX_PLCQualityCriterionDatas_MachineID",
                table: "PLCQualityCriterionDatas",
                column: "MachineID");

            migrationBuilder.AddForeignKey(
                name: "FK_PLCQualityCriterionDatas_Machines_MachineID",
                table: "PLCQualityCriterionDatas",
                column: "MachineID",
                principalTable: "Machines",
                principalColumn: "ConnectionID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PLCQualityCriterionDatas_Machines_MachineID",
                table: "PLCQualityCriterionDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLCQualityCriterionDatas",
                table: "PLCQualityCriterionDatas");

            migrationBuilder.DropIndex(
                name: "IX_PLCQualityCriterionDatas_MachineID",
                table: "PLCQualityCriterionDatas");

            migrationBuilder.RenameTable(
                name: "PLCQualityCriterionDatas",
                newName: "Datas");

            migrationBuilder.AlterColumn<float>(
                name: "DataValue",
                table: "Datas",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<float>(
                name: "DataDifferenceValue",
                table: "Datas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "Times",
                table: "Datas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Datas",
                table: "Datas",
                column: "OID");
        }
    }
}
