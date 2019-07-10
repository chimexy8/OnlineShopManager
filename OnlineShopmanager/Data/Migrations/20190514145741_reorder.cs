using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShopmanager.Data.Migrations
{
    public partial class reorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReorderLevel",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ReorderLevel",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
