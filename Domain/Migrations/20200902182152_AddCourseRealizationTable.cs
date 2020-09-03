using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddCourseRealizationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseRealizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PreschoolInstitutionID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    CompletionDay = table.Column<DateTime>(nullable: false),
                    NumberOfParticipants = table.Column<int>(nullable: true),
                    ZUOVPassword = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRealizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseRealizations_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRealizations_PreschoolInstitutions_PreschoolInstitutionID",
                        column: x => x.PreschoolInstitutionID,
                        principalTable: "PreschoolInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRealizations_CourseID",
                table: "CourseRealizations",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRealizations_PreschoolInstitutionID",
                table: "CourseRealizations",
                column: "PreschoolInstitutionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRealizations");
        }
    }
}
