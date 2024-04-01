using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTierCvPro.DataAccessLayer.Migrations
{
    public partial class isimduzeltildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sertifikalarım",
                table: "Sertifikalarım");

            migrationBuilder.RenameTable(
                name: "Sertifikalarım",
                newName: "Sertifikalarim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sertifikalarim",
                table: "Sertifikalarim",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sertifikalarim",
                table: "Sertifikalarim");

            migrationBuilder.RenameTable(
                name: "Sertifikalarim",
                newName: "Sertifikalarım");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sertifikalarım",
                table: "Sertifikalarım",
                column: "ID");
        }
    }
}
