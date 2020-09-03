using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddTableInvoiceItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceItem",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(nullable: false),
                    TrainerID = table.Column<int>(nullable: false),
                    YearID = table.Column<int>(nullable: false),
                    CourseRealizationID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Days = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItem", x => new { x.InvoiceID, x.YearID, x.TrainerID, x.CourseRealizationID });
                    table.ForeignKey(
                        name: "FK_InvoiceItem_CourseRealizations_CourseRealizationID",
                        column: x => x.CourseRealizationID,
                        principalTable: "CourseRealizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Invoices_InvoiceID_TrainerID_YearID",
                        columns: x => new { x.InvoiceID, x.TrainerID, x.YearID },
                        principalTable: "Invoices",
                        principalColumns: new[] { "Id", "TrainerID", "YearID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_CourseRealizationID",
                table: "InvoiceItem",
                column: "CourseRealizationID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_InvoiceID_TrainerID_YearID",
                table: "InvoiceItem",
                columns: new[] { "InvoiceID", "TrainerID", "YearID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceItem");
        }
    }
}
