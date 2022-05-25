using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupWebApp.Storage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ByIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingredient = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ByIngredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalKitchens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitchenName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalKitchens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfPreparations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfPreparations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BySubIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubIngredient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ByIngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BySubIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BySubIngredients_ByIngredients_ByIngredientId",
                        column: x => x.ByIngredientId,
                        principalTable: "ByIngredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte>(type: "tinyint", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    NationalKitchenId = table.Column<int>(type: "int", nullable: false),
                    TypeOfPreparationId = table.Column<int>(type: "int", nullable: false),
                    BySubIngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_BySubIngredients_BySubIngredientId",
                        column: x => x.BySubIngredientId,
                        principalTable: "BySubIngredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_NationalKitchens_NationalKitchenId",
                        column: x => x.NationalKitchenId,
                        principalTable: "NationalKitchens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_TypeOfPreparations_TypeOfPreparationId",
                        column: x => x.TypeOfPreparationId,
                        principalTable: "TypeOfPreparations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BySubIngredients_ByIngredientId",
                table: "BySubIngredients",
                column: "ByIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_BySubIngredientId",
                table: "Recipes",
                column: "BySubIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_NationalKitchenId",
                table: "Recipes",
                column: "NationalKitchenId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_SubCategoryId",
                table: "Recipes",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TypeOfPreparationId",
                table: "Recipes",
                column: "TypeOfPreparationId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "BySubIngredients");

            migrationBuilder.DropTable(
                name: "NationalKitchens");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "TypeOfPreparations");

            migrationBuilder.DropTable(
                name: "ByIngredients");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
