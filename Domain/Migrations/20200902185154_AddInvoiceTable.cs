using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddInvoiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrainerID = table.Column<int>(nullable: false),
                    YearID = table.Column<int>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    DateInvoice = table.Column<DateTime>(nullable: false),
                    WageID = table.Column<int>(nullable: false),
                    WageAmount = table.Column<decimal>(nullable: false),
                    Satus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Trainers_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Wages_WageID",
                        column: x => x.WageID,
                        principalTable: "Wages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_TrainerID",
                table: "Invoices",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_WageID",
                table: "Invoices",
                column: "WageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
