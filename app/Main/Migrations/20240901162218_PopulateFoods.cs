using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Main.Migrations
{
    public partial class PopulateFoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods;");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Foods', RESEED, 0);");
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Name", "Description", "DetailedDescription", "ImageUrl", "ThumbnailUrl", "Price", "IsAvailable", "IsFavorite", "CategoryId" },
                values: new object[,]
                    {
                        { "Coxinha", "Coxinha de frango", "Coxinha de frango com massa crocante", "https://cdn.urbano.com.br/uploads/coxinha-receitas-urbano-alimentos-800.jpg", "https://cdn.urbano.com.br/uploads/coxinha-receitas-urbano-alimentos-800.jpg", 2.50m, true, true, 1 },
                        { "Brigadeiro", "Brigadeiro de chocolate", "Brigadeiro de chocolate com granulado", "https://i.panelinha.com.br/i1/228-q-2859-brigadeiro.webp", "https://i.panelinha.com.br/i1/228-q-2859-brigadeiro.webp", 1.50m, true, true, 2 },
                        { "Coca-Cola", "Coca-Cola", "Coca-Cola 2L", "https://io.convertiez.com.br/m/trimais/shop/products/images/2/medium/refrigerante-coca-cola-original-garrafa-2l_2.jpg", "https://io.convertiez.com.br/m/trimais/shop/products/images/2/medium/refrigerante-coca-cola-original-garrafa-2l_2.jpg", 9.85m, true, true, 3}
                    }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods;");
        }
    }
}
