using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddWageOnInvoiceItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Wages_WageID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_WageID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "WageAmount",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "WageID",
                table: "Invoices");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "InvoiceItem",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WageId",
                table: "InvoiceItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_WageId",
                table: "InvoiceItem",
                column: "WageId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Wages_WageId",
                table: "InvoiceItem",
                column: "WageId",
                principalTable: "Wages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Wages_WageId",
                table: "InvoiceItem");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceItem_WageId",
                table: "InvoiceItem");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "InvoiceItem");

            migrationBuilder.DropColumn(
                name: "WageId",
                table: "InvoiceItem");

            migrationBuilder.AddColumn<decimal>(
                name: "WageAmount",
                table: "Invoices",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "WageID",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_WageID",
                table: "Invoices",
                column: "WageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Wages_WageID",
                table: "Invoices",
                column: "WageID",
                principalTable: "Wages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
