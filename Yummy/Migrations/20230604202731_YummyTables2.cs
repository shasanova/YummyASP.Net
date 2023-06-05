using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Migrations
{
    public partial class YummyTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ChefSocialMedia_ChefId",
                table: "ChefSocialMedia");

            migrationBuilder.CreateIndex(
                name: "IX_ChefSocialMedia_ChefId",
                table: "ChefSocialMedia",
                column: "ChefId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ChefSocialMedia_ChefId",
                table: "ChefSocialMedia");

            migrationBuilder.CreateIndex(
                name: "IX_ChefSocialMedia_ChefId",
                table: "ChefSocialMedia",
                column: "ChefId");
        }
    }
}
