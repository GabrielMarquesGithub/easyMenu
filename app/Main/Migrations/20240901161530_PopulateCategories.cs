using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Main.Migrations
{
    public partial class PopulateCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories;");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Categories', RESEED, 1);");
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "Description" },
                values: new object[,]
                {
                    { "Salgados", "Salgados diversos" },
                    { "Doces", "Doces diversos" },
                    { "Bebidas", "Bebidas diversas"}
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories;");
        }
    }
}
