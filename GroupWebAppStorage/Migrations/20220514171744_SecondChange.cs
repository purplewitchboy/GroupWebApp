using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupWebApp.Storage.Migrations
{
    public partial class SecondChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "BySubIngredientId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalKitchenId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfPreparationId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_BySubIngredients_ByIngredientId",
                table: "BySubIngredients",
                column: "ByIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_BySubIngredients_BySubIngredientId",
                table: "Recipes",
                column: "BySubIngredientId",
                principalTable: "BySubIngredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_NationalKitchens_NationalKitchenId",
                table: "Recipes",
                column: "NationalKitchenId",
                principalTable: "NationalKitchens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_SubCategories_SubCategoryId",
                table: "Recipes",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_TypeOfPreparations_TypeOfPreparationId",
                table: "Recipes",
                column: "TypeOfPreparationId",
                principalTable: "TypeOfPreparations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_BySubIngredients_BySubIngredientId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_NationalKitchens_NationalKitchenId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_SubCategories_SubCategoryId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_TypeOfPreparations_TypeOfPreparationId",
                table: "Recipes");

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

            migrationBuilder.DropIndex(
                name: "IX_Recipes_BySubIngredientId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_NationalKitchenId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_SubCategoryId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_TypeOfPreparationId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "BySubIngredientId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "NationalKitchenId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TypeOfPreparationId",
                table: "Recipes");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
