using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Platform_Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarot",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arcana = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Suit = table.Column<int>(type: "int", nullable: false),
                    RWImage = table.Column<int>(type: "int", nullable: false),
                    Court = table.Column<bool>(type: "bit", nullable: false),
                    Element = table.Column<byte>(type: "BINARY(5)", nullable: false),
                    Astrology = table.Column<byte>(type: "BINARY(50)", nullable: false),
                    Sephirot = table.Column<byte>(type: "BINARY(50)", nullable: false),
                    Tetragrammaton = table.Column<byte>(type: "BINARY(50)", nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HermeticTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HermeticMeaningUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HermeticMeaningInv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HermeticDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkelenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EkelenMeaningUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EkelenMeaningInv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EkelenDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiddyMeaningUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiddyMeaningInv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiddyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarot", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarot");
        }
    }
}
