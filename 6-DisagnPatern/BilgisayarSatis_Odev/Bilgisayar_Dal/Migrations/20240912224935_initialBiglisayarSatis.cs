using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bilgisayar_Dal.Migrations
{
    /// <inheritdoc />
    public partial class initialBiglisayarSatis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anakarts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @decimal = table.Column<decimal>(name: "decimal", type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anakarts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EkranKarts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @decimal = table.Column<decimal>(name: "decimal", type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkranKarts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Islemcis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @decimal = table.Column<decimal>(name: "decimal", type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islemcis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Markas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @decimal = table.Column<decimal>(name: "decimal", type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @decimal = table.Column<decimal>(name: "decimal", type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @decimal = table.Column<decimal>(name: "decimal", type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bilgisayars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnakartID = table.Column<int>(type: "int", nullable: false),
                    EkranKartıID = table.Column<int>(type: "int", nullable: false),
                    IslemciID = table.Column<int>(type: "int", nullable: false),
                    MarkaID = table.Column<int>(type: "int", nullable: false),
                    ModelID = table.Column<int>(type: "int", nullable: false),
                    RamID = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilgisayars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bilgisayars_Anakarts_AnakartID",
                        column: x => x.AnakartID,
                        principalTable: "Anakarts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilgisayars_EkranKarts_EkranKartıID",
                        column: x => x.EkranKartıID,
                        principalTable: "EkranKarts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilgisayars_Islemcis_IslemciID",
                        column: x => x.IslemciID,
                        principalTable: "Islemcis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilgisayars_Markas_MarkaID",
                        column: x => x.MarkaID,
                        principalTable: "Markas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilgisayars_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilgisayars_Rams_RamID",
                        column: x => x.RamID,
                        principalTable: "Rams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilgisayars_AnakartID",
                table: "Bilgisayars",
                column: "AnakartID");

            migrationBuilder.CreateIndex(
                name: "IX_Bilgisayars_EkranKartıID",
                table: "Bilgisayars",
                column: "EkranKartıID");

            migrationBuilder.CreateIndex(
                name: "IX_Bilgisayars_IslemciID",
                table: "Bilgisayars",
                column: "IslemciID");

            migrationBuilder.CreateIndex(
                name: "IX_Bilgisayars_MarkaID",
                table: "Bilgisayars",
                column: "MarkaID");

            migrationBuilder.CreateIndex(
                name: "IX_Bilgisayars_ModelID",
                table: "Bilgisayars",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Bilgisayars_RamID",
                table: "Bilgisayars",
                column: "RamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilgisayars");

            migrationBuilder.DropTable(
                name: "Anakarts");

            migrationBuilder.DropTable(
                name: "EkranKarts");

            migrationBuilder.DropTable(
                name: "Islemcis");

            migrationBuilder.DropTable(
                name: "Markas");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Rams");
        }
    }
}
