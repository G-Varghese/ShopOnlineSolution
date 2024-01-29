using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Earring" },
                    { 2, "Necklace" },
                    { 3, "Bangles/Bracelets" },
                    { 4, "Anklet" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "Stylish and trendy traditional white pearl gold jhumka", "/Images/Earrings/Earrings1.png", "White Pearl Gold Drop Jhumka", 50m, 200 },
                    { 2, 1, "Muticolor stone statement earring, captivating crystal and an eye catchy lion drop", "/Images/Earrings/Earrings2.png", "Contemporary Crystal Stone", 50m, 45 },
                    { 3, 1, "Handcrafted in silver and brass alloy with cz stones", "/Images/Earrings/Earrings3.png", "Red Ruby Stones", 20m, 30 },
                    { 4, 1, "Gold and white earrings featured the iconic image of Radha and Krishna ", "/Images/Earrings/Earrings4.png", "Kundan Bahubali Earrings ", 50m, 60 },
                    { 5, 1, "Black and gold plated enamelled dome shaped jhumkas", "/Images/Earrings/Earrings5.png", "Dome shaped Jhumkas", 30m, 85 },
                    { 6, 3, "Gold plated set of 12 classy design", "/Images/Bangles/Bangles1.png", "Gold Set of 12", 100m, 120 },
                    { 7, 3, "Premium quality brass base opeable bangle with multiple stones", "/Images/Bangles/Bangles2.png", "Brass Openable Kada", 40m, 200 },
                    { 8, 3, "Alloy base material with white beads", "/Images/Bangles/Bangles3.png", "Gold Beaded Bangle", 40m, 300 },
                    { 9, 3, "Enameled gold plated leaf shaped bangle set", "/Images/Bangles/Bangles4.png", "Leaf Shaped bangle Set", 600m, 20 },
                    { 10, 3, "Traditional Blue and Golden color jumuka bangle set", "/Images/Bangles/Bangles5.png", "Jumuka Bangle Set", 500m, 15 },
                    { 11, 3, "Rajwadhi plated elephant design brass kada", "/Images/Bangles/Bangles6.png", "Elephant Design Kada", 100m, 60 },
                    { 12, 2, "Golden necklace with laxmi pendant and green color stones", "/Images/Necklaces/Necklaces1.png", "Laxmi Pendant Necklace", 50m, 212 },
                    { 13, 2, "Three layered red color beaded neckpiece", "/Images/Necklaces/Necklaces2.png", "Red Beaded Necklace", 50m, 112 },
                    { 14, 2, "Alloy base material yellow gold plating necklace ", "/Images/Necklaces/Necklaces3.png", "Golden Necklace", 70m, 90 },
                    { 15, 2, "Alloy material with gold antique tassel necklace", "/Images/Necklaces/Necklaces4.png", "Antique Tassel Necklaces", 120m, 95 },
                    { 16, 2, "Handcrfted in brass alloy with ruby, pearl and meenakari work", "/Images/Necklaces/Necklaces5.png", "Red Ruby Necklace", 15m, 100 },
                    { 17, 2, "Golden brahmamudi long mangalsuthra with single vathi", "/Images/Necklaces/Necklaces6.png", "Long Mangalsuthra", 20m, 73 },
                    { 18, 4, "Bridal baraat muti-colored patterend angle", "/Images/Anklets/Anklets1.png", "Baraat Patterened Angle", 100m, 50 },
                    { 19, 4, "Beaurtifil Copper alloy polki's with white beads", "/Images/Anklets/Anklets2.png", "Polki's Anklet", 150m, 60 },
                    { 20, 4, "Simple light weight elegant golden chain anklet", "/Images/Anklets/Anklets3.png", "Golden Chain Anklet", 200m, 70 },
                    { 21, 4, "Beautiful simple silver paecock design anklet", "/Images/Anklets/Anklets4.png", "Peacock Design Anklet", 120m, 120 },
                    { 22, 4, "Simple round shaped gold anklet", "/Images/Anklets/Anklets5.png", "Gold Anklet", 200m, 100 },
                    { 23, 4, "Gold Plated anklet with muticolored stones", "/Images/Anklets/Anklets6.png", "Gold Stone Anklet", 50m, 150 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Bob" },
                    { 2, "Sarah" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
