using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddCourseRealizationConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZUOVPassword",
                table: "CourseRealizations",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZUOVPassword",
                table: "CourseRealizations",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
