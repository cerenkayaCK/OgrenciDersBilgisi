using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OgrenciDersBilgisi.Migrations
{
    /// <inheritdoc />
    public partial class IlkGoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarfNotu = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Kredi = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "Id", "Ad", "HarfNotu", "Kod", "Kredi" },
                values: new object[,]
                {
                    { 1, "İleri Programlama", "A", "BİL256", 3.0 },
                    { 2, "Genel Matematik", "B", "MAT178", 3.0 },
                    { 3, "İngilizce II", "D", "İNG262", 2.0 },
                    { 4, "Seçmeli Ders I", "C", "SEÇ401", 1.0 },
                    { 5, "Olasılık", "F", "İST244", 4.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dersler");
        }
    }
}
