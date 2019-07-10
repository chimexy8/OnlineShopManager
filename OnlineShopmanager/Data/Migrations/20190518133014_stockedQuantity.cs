using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShopmanager.Data.Migrations
{
    public partial class stockedQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableQuantity",
                table: "Products",
                newName: "StockedQuantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockedQuantity",
                table: "Products",
                newName: "AvailableQuantity");
        }
    }
}
