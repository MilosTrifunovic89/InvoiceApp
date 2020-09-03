using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddContactPersonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PreschoolInstitutionContactPeople",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PreschoolInstitutionId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreschoolInstitutionContactPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreschoolInstitutionContactPeople_PreschoolInstitutions_PreschoolInstitutionId",
                        column: x => x.PreschoolInstitutionId,
                        principalTable: "PreschoolInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreschoolInstitutionContactPeople_PreschoolInstitutionId",
                table: "PreschoolInstitutionContactPeople",
                column: "PreschoolInstitutionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreschoolInstitutionContactPeople");
        }
    }
}
