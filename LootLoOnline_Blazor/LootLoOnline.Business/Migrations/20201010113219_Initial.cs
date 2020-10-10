using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LootLoOnline.Business.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DealsOfTheDays",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startTime = table.Column<DateTime>(nullable: true),
                    endTime = table.Column<DateTime>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    imageUrls_default = table.Column<string>(nullable: true),
                    imageUrls_mid = table.Column<string>(nullable: true),
                    imageUrls_low = table.Column<string>(nullable: true),
                    availability = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealsOfTheDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfferProducts",
                columns: table => new
                {
                    productId = table.Column<string>(nullable: false),
                    validTill = table.Column<DateTime>(nullable: true),
                    shotTitle = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    productDescription = table.Column<string>(nullable: true),
                    imageUrls_200 = table.Column<string>(nullable: true),
                    imageUrls_400 = table.Column<string>(nullable: true),
                    imageUrls_800 = table.Column<string>(nullable: true),
                    productFamily = table.Column<string>(nullable: true),
                    maximumRetailPrice = table.Column<decimal>(nullable: false),
                    SellingPrice = table.Column<decimal>(nullable: false),
                    SpecialPrice = table.Column<decimal>(nullable: false),
                    currency = table.Column<string>(nullable: true),
                    productUrl = table.Column<string>(nullable: true),
                    productBrand = table.Column<string>(nullable: true),
                    inStock = table.Column<bool>(nullable: true),
                    codAvailable = table.Column<bool>(nullable: true),
                    discountPercentage = table.Column<decimal>(nullable: true),
                    offers = table.Column<string>(nullable: true),
                    categoryPath = table.Column<string>(nullable: true),
                    attributes = table.Column<string>(nullable: true),
                    shippingCharges = table.Column<decimal>(nullable: true),
                    estimatedDeliveryTime = table.Column<string>(nullable: true),
                    sellerName = table.Column<string>(nullable: true),
                    sellerAverageRating = table.Column<decimal>(nullable: true),
                    sellerNoOfRatings = table.Column<decimal>(nullable: true),
                    sellerNoOfReviews = table.Column<decimal>(nullable: true),
                    keySpecs = table.Column<string>(nullable: true),
                    detailedSpecs = table.Column<string>(nullable: true),
                    specificationList = table.Column<string>(nullable: true),
                    booksInfo = table.Column<string>(nullable: true),
                    lifeStyleInfo = table.Column<string>(nullable: true),
                    IsUpdated = table.Column<bool>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    SiteName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferProducts", x => x.productId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DealsOfTheDays");

            migrationBuilder.DropTable(
                name: "OfferProducts");
        }
    }
}
