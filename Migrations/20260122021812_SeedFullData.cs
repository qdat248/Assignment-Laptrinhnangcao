using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebBanDoAn.Migrations
{
    /// <inheritdoc />
    public partial class SeedFullData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Description",
                value: "Burger, Gà rán, Pizza");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "Description",
                value: "Nước ngọt, trà, cafe");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 3, "Combo", "Combo tiết kiệm" });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "ComboID", "ComboName", "Description", "Price" },
                values: new object[,]
                {
                    { 1, "Combo Tiết Kiệm", "1 Burger + 1 Coca", 80000.0 },
                    { 2, "Combo Gia Đình", "2 Burger + 2 Gà rán + 2 Nước", 180000.0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Burger bò truyền thống", "burger_bo.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CategoryID", "Description", "Image", "Price", "ProductName" },
                values: new object[] { 1, "Burger gà giòn", "burger_ga.jpg", 50000.0, "Burger Gà" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "Image", "Price", "ProductName" },
                values: new object[,]
                {
                    { 3, 1, "Gà rán giòn rụm", "ga_ran.jpg", 45000.0, "Gà rán" },
                    { 4, 2, "Nước ngọt có ga", "coca.jpg", 15000.0, "Coca Cola" },
                    { 5, 2, "Pepsi mát lạnh", "pepsi.jpg", 15000.0, "Pepsi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "Email", "FullName", "GoogleID", "NumberPhone", "Pass", "Role" },
                values: new object[,]
                {
                    { 1, "FPT Polytechnic", "admin@fastfood.com", "Admin System", null, "0900000000", "123456", "Admin" },
                    { 2, "Hà Nội", "customer1@gmail.com", "Nguyễn Văn A", null, "0911111111", "123456", "Customer" },
                    { 3, "TP.HCM", "customer2@gmail.com", "Trần Thị B", "google_123456", "0922222222", "123456", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderDate", "Status", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 22, 9, 18, 11, 586, DateTimeKind.Local).AddTicks(58), "Đã giao", 95000.0, 2 },
                    { 2, new DateTime(2026, 1, 22, 9, 18, 11, 586, DateTimeKind.Local).AddTicks(72), "Đang giao", 180000.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "ComboID", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, null, 1, 1, 1, 55000.0 },
                    { 2, null, 1, 4, 1, 15000.0 },
                    { 3, 2, 2, null, 1, 180000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Description",
                value: "Burger, Gà rán...");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "Description",
                value: "Nước ngọt, cafe...");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Ngon tuyệt", "burger.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CategoryID", "Description", "Image", "Price", "ProductName" },
                values: new object[] { 2, "Lạnh", "coca.jpg", 15000.0, "Coca Cola" });
        }
    }
}
