using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTablePaginationEFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(11,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Price" },
                values: new object[,]
                {
                    { 1L, "Pizza 1", 10m },
                    { 2L, "Blue-Ray", 60m },
                    { 3L, "DVD", 20m },
                    { 4L, "T-Shirt", 20.5m },
                    { 5L, "Computer", 350.99m },
                    { 6L, "Laptop", 200m },
                    { 7L, "Car", 5000m },
                    { 8L, "Mug", 5.5m },
                    { 9L, "Cup", 2.5m },
                    { 10L, "Fork", 1.99m },
                    { 11L, "Knife", 6.5m },
                    { 12L, "Gift Card", 0.88m },
                    { 13L, "Chair", 100.87m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
