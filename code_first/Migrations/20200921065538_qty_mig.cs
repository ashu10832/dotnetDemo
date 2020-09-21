using Microsoft.EntityFrameworkCore.Migrations;

namespace code_first.Migrations
{
    public partial class qty_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "StoreDTO",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "StoreDTO");
        }
    }
}
