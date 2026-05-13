using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frmKutuphane.Migrations
{
    /// <inheritdoc />
    public partial class sekizinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Kitaplar");

            migrationBuilder.AddColumn<int>(
                name: "DurumId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Durum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurumAdi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durum", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_DurumId",
                table: "Kitaplar",
                column: "DurumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Durum_DurumId",
                table: "Kitaplar",
                column: "DurumId",
                principalTable: "Durum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Durum_DurumId",
                table: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Durum");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_DurumId",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "DurumId",
                table: "Kitaplar");

            migrationBuilder.AddColumn<short>(
                name: "Durum",
                table: "Kitaplar",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
