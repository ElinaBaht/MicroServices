using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2cad8b9d-05e8-4685-a122-0622bdd6a201"), "Appetizer", "Test", "Salad", 10.0 },
                    { new Guid("61d46d68-1450-4b5f-968f-54c52cc423c5"), "Dessert", "Test", "Pie", 8.9900000000000002 },
                    { new Guid("8ff2a7bd-bc1a-4e92-8966-cfe9ee433a83"), "Appetizer", "Test", "Snacks", 15.0 },
                    { new Guid("c19122af-3455-4d23-aa77-f199c573cee4"), "Entree", "Test", "Pasta", 18.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2cad8b9d-05e8-4685-a122-0622bdd6a201"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("61d46d68-1450-4b5f-968f-54c52cc423c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8ff2a7bd-bc1a-4e92-8966-cfe9ee433a83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c19122af-3455-4d23-aa77-f199c573cee4"));
        }
    }
}
