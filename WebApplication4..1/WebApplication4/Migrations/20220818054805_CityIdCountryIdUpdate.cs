using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class CityIdCountryIdUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_State_City_CityId",
                table: "State");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "State",
                newName: "City_Id");

            migrationBuilder.RenameIndex(
                name: "IX_State_CityId",
                table: "State",
                newName: "IX_State_City_Id");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "City",
                newName: "countryID");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryID",
                table: "City",
                newName: "IX_City_countryID");

            migrationBuilder.AlterColumn<int>(
                name: "countryID",
                table: "City",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Country_ID",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_countryID",
                table: "City",
                column: "countryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_State_City_City_Id",
                table: "State",
                column: "City_Id",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_countryID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_State_City_City_Id",
                table: "State");

            migrationBuilder.DropColumn(
                name: "Country_ID",
                table: "City");

            migrationBuilder.RenameColumn(
                name: "City_Id",
                table: "State",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_State_City_Id",
                table: "State",
                newName: "IX_State_CityId");

            migrationBuilder.RenameColumn(
                name: "countryID",
                table: "City",
                newName: "CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_City_countryID",
                table: "City",
                newName: "IX_City_CountryID");

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryID",
                table: "City",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_State_City_CityId",
                table: "State",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
