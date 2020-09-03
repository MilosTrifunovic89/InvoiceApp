using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Municipality = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreschoolInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TerritoryId = table.Column<int>(nullable: false),
                    PIName = table.Column<string>(nullable: true),
                    PIIDMinistry = table.Column<int>(nullable: true),
                    StartYearImplementation = table.Column<int>(nullable: true),
                    Cohort = table.Column<int>(nullable: true),
                    NumerOfInstitutions = table.Column<int>(nullable: true),
                    NumberOfTeachers = table.Column<int>(nullable: true),
                    NumberOfProfessionalAssosiates = table.Column<int>(nullable: true),
                    NumberOfParticipants = table.Column<int>(nullable: true),
                    NumberOfProjectors = table.Column<int>(nullable: true),
                    NumberOfLaptops = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreschoolInstitutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreschoolInstitutions_Territories_TerritoryId",
                        column: x => x.TerritoryId,
                        principalTable: "Territories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreschoolInstitutions_TerritoryId",
                table: "PreschoolInstitutions",
                column: "TerritoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreschoolInstitutions");

            migrationBuilder.DropTable(
                name: "Territories");
        }
    }
}
