using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frmKutuphane.Migrations
{
    /// <inheritdoc />
    public partial class onuncu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Durum_DurumId",
                table: "Kitaplar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Durum",
                table: "Durum");

            migrationBuilder.RenameTable(
                name: "Durum",
                newName: "Durumlar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Durumlar",
                table: "Durumlar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Durumlar_DurumId",
                table: "Kitaplar",
                column: "DurumId",
                principalTable: "Durumlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Durumlar_DurumId",
                table: "Kitaplar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Durumlar",
                table: "Durumlar");

            migrationBuilder.RenameTable(
                name: "Durumlar",
                newName: "Durum");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Durum",
                table: "Durum",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Durum_DurumId",
                table: "Kitaplar",
                column: "DurumId",
                principalTable: "Durum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
