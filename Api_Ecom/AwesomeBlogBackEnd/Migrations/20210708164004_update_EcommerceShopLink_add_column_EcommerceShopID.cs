using Microsoft.EntityFrameworkCore.Migrations;

namespace AwesomeBlogBackEnd.Migrations
{
    public partial class update_EcommerceShopLink_add_column_EcommerceShopID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EcommerceShopID",
                table: "EcommerceShopLinks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EcommerceShopID",
                table: "EcommerceShopLinks");
        }
    }
}
