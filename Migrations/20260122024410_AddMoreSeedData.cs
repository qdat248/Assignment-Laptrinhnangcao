using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebBanDoAn.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 4, "Gà rán", "Các món gà chiên giòn" },
                    { 5, "Pizza", "Pizza các loại" },
                    { 6, "Tráng miệng", "Bánh ngọt, kem" }
                });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 2,
                column: "Description",
                value: "2 Burger + 2 Gà rán  + 2 Nước");

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "ComboID", "ComboName", "Description", "Price" },
                values: new object[,]
                {
                    { 3, "Combo Cặp Đôi", "2 Burger + 2 Nước", 190000.0 },
                    { 4, "Combo Bố Con", "2 Burger + 2 Gà rán + 2 Pizza  + 2 Nước", 200000.0 },
                    { 5, "Combo Đặc Biệt", "2 Burger + 2 Gà rán + 2 Pizza + 2 Tráng Miệng + 2 Nước", 220000.0 },
                    { 6, "Combo Gà Rán", "2 Gà rán + 1 Coca", 170000.0 },
                    { 7, "Combo Pizza", "1 Pizza + 2 Nước", 150000.0 },
                    { 8, "Combo Sinh Viên", "Burger + Nước + Khoai", 160000.0 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 1, 22, 9, 44, 9, 788, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 1, 22, 9, 44, 9, 788, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "Email", "FullName", "GoogleID", "NumberPhone", "Pass", "Role" },
                values: new object[,]
                {
                    { 4, "Đà Nẵng", "customer3@gmail.com", "Lê Văn C", null, "0933333333", "123456", "Customer" },
                    { 5, "Cần Thơ", "customer4@gmail.com", "Phạm Thị D", "google_78910", "0944444444", "123456", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderDate", "Status", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2026, 1, 22, 9, 44, 9, 788, DateTimeKind.Local).AddTicks(593), "Chưa giao", 95000.0, 4 },
                    { 4, new DateTime(2026, 1, 22, 9, 44, 9, 788, DateTimeKind.Local).AddTicks(594), "Đã giao", 150000.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "Image", "Price", "ProductName" },
                values: new object[,]
                {
                    { 6, 4, "Gà cay Hàn Quốc", "ga_cay.jpg", 48000.0, "Gà rán cay" },
                    { 7, 4, "Gà rán giòn", "ga_truyen_thong.jpg", 45000.0, "Gà rán truyền thống" },
                    { 8, 5, "Pizza hải sản phô mai", "pizza_hai_san.jpg", 120000.0, "Pizza Hải Sản" },
                    { 9, 5, "Pizza bò nướng", "pizza_bo.jpg", 110000.0, "Pizza Bò" },
                    { 10, 6, "Kem mát lạnh", "kem_vani.jpg", 20000.0, "Kem Vani" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "ComboID", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 4, null, 3, 6, 2, 48000.0 },
                    { 5, 4, 4, null, 1, 150000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "ComboID",
                keyValue: 2,
                column: "Description",
                value: "2 Burger + 2 Gà rán + 2 Nước");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 1, 22, 9, 18, 11, 586, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 1, 22, 9, 18, 11, 586, DateTimeKind.Local).AddTicks(72));
        }
    }
}
