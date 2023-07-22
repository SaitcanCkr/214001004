using Microsoft.EntityFrameworkCore.Migrations;

namespace _214001004.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KullaniciYetki",
                table: "Kullanici",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullaniciYetki",
                table: "Kullanici");
        }
    }
}
