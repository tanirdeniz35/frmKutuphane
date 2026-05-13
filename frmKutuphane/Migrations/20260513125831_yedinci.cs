using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frmKutuphane.Migrations
{
    /// <inheritdoc />
    public partial class yedinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Durum",
                table: "Kitaplar",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Kitaplar");
        }
    }
}
