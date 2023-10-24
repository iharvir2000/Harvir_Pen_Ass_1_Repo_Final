using Microsoft.EntityFrameworkCore.Migrations;

namespace Harvir_Pen_Ass_1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    InkColor = table.Column<string>(nullable: true),
                    IsBallpoint = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pen", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pen");
        }
    }
}
