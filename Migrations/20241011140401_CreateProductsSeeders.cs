using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductsAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateProductsSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_category_id",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_category_id",
                table: "products");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_id", "description", "name", "price", "stock" },
                values: new object[,]
                {
                    { 1, 1, "The latest Samsung Galaxy S21 from Samsung.", "Samsung Galaxy S21 Ultra", 999.99000000000001, 4 },
                    { 2, 1, "The latest Apple iPhone 12 Pro Max from Apple.", "Apple iPhone 12 Pro Max", 1299.99, 10 },
                    { 3, 2, "The latest Nike Air Max 97 from Nike.", "Nike Air Max 97", 149.99000000000001, 20 },
                    { 4, 3, "A philosophical novel by Paulo Coelho.", "The Alchemist", 19.989999999999998, 50 },
                    { 5, 4, "High-performance vacuum cleaner for home use.", "Dyson V11 Vacuum Cleaner", 599.99000000000001, 5 },
                    { 6, 5, "Professional-grade tennis racket for sports enthusiasts.", "Wilson Tennis Racket", 199.99000000000001, 15 },
                    { 7, 6, "Detailed Lego set of the Millennium Falcon.", "Lego Star Wars Millennium Falcon", 149.99000000000001, 30 },
                    { 8, 7, "Advanced electric toothbrush for dental care.", "Oral-B Electric Toothbrush", 89.989999999999995, 100 },
                    { 9, 8, "Durable and high-performance tires for all seasons.", "Michelin All-Season Tires", 129.99000000000001, 25 },
                    { 10, 9, "All-in-one wireless printer for office use.", "HP OfficeJet Pro Printer", 199.99000000000001, 8 },
                    { 11, 10, "7-in-1 electric pressure cooker for quick meals.", "Instant Pot Duo", 89.989999999999995, 35 },
                    { 12, 1, "Noise-canceling over-ear headphones for music lovers.", "Sony WH-1000XM4 Headphones", 349.99000000000001, 20 },
                    { 13, 2, "High-performance running shoes for athletes.", "Adidas Ultraboost 21", 180.0, 60 },
                    { 14, 3, "A bestselling self-improvement book by James Clear.", "Atomic Habits", 24.989999999999998, 40 },
                    { 15, 4, "Compact gas grill for outdoor cooking.", "Weber Spirit Gas Grill", 499.99000000000001, 12 },
                    { 16, 5, "Advanced fitness tracker with GPS.", "Fitbit Charge 5", 179.99000000000001, 45 },
                    { 17, 6, "High-performance toy blaster for kids.", "Nerf Elite Blaster", 39.990000000000002, 60 },
                    { 18, 7, "Hydrating facial moisturizer for dry skin.", "Neutrogena Hydro Boost", 24.989999999999998, 80 },
                    { 19, 8, "High-performance motor oil for engines.", "Castrol GTX Motor Oil", 29.989999999999998, 100 },
                    { 20, 9, "Ergonomic office chair for maximum comfort.", "Staples Office Chair", 149.99000000000001, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                table: "products",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_category_id",
                table: "products",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
