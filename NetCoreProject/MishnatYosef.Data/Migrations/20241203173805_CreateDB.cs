using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MishnatYosef.Data.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnotherPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnotherPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnotherPhone3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardValidity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cvv = table.Column<int>(type: "int", nullable: false),
                    Station = table.Column<int>(type: "int", nullable: false),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station = table.Column<int>(type: "int", nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationManagerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationManagerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationUsherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationUsherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionStations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sell = table.Column<int>(type: "int", nullable: false),
                    Customer = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderAmount = table.Column<double>(type: "float", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderedProduct = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsOnSell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sell = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<int>(type: "int", nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOnSell", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ClosingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    day = table.Column<int>(type: "int", nullable: false),
                    SellHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Station = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sells", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DistributionStations");

            migrationBuilder.DropTable(
                name: "OrderedProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductsOnSell");

            migrationBuilder.DropTable(
                name: "Sells");
        }
    }
}
