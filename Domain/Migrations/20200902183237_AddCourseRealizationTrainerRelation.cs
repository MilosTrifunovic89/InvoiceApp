using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddCourseRealizationTrainerRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseRealizationTrainers",
                columns: table => new
                {
                    TrainerID = table.Column<int>(nullable: false),
                    CourseRealizationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRealizationTrainers", x => new { x.TrainerID, x.CourseRealizationID });
                    table.ForeignKey(
                        name: "FK_CourseRealizationTrainers_CourseRealizations_CourseRealizationID",
                        column: x => x.CourseRealizationID,
                        principalTable: "CourseRealizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRealizationTrainers_Trainers_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRealizationTrainers_CourseRealizationID",
                table: "CourseRealizationTrainers",
                column: "CourseRealizationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRealizationTrainers");
        }
    }
}
